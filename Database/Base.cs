using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace Database
{
    /// <summary>
    /// Base
    /// </summary>
    public class Base : IBase
    {
        /// <summary>
        /// connectionString
        /// </summary>
        private string connString = ConfigurationManager.AppSettings["SqlConnection"];

        public string Key
        {
            get
            {
                // this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                // -> Obtém uma lista de propriedades tanto públicas quanto instância
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase opcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                    if (opcoesBase != null && opcoesBase.ChavePrimaria)
                        return Convert.ToString(pi.GetValue(this));
                }
                return null;
            }
        }

        /// <summary>
        /// Realiza busca
        /// </summary>
        /// <returns>Lista</returns>
        public List<IBase> Buscar()
        {
            var list = new List<IBase>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                List<string> valores = new List<string>();
                string chavePrimaria = string.Empty;
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase opcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                    if (opcoesBase != null)
                    {
                        if (opcoesBase.ChavePrimaria)
                            chavePrimaria = pi.Name;

                        if (opcoesBase.UsarParaBuscar)
                        {
                            var valor = pi.GetValue(this);
                            if (valor != null)
                                valores.Add(string.Concat(pi.Name, " = '", valor, "'"));
                        }
                    }
                }

                string queryString = $"SELECT * FROM {this.GetType().Name}s WHERE {chavePrimaria} IS NOT NULL";
                if (valores.Count > 0)
                    queryString = string.Concat(queryString, " and ", string.Join(" and ", valores.ToArray()));

                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    SetProperty(ref obj, reader);
                    list.Add(obj);
                }
                return list;
            }
        }

        /// <summary>
        /// Método que salva na base
        /// </summary>
        public virtual void Salvar()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                List<string> campos = new List<string>();
                List<string> valores = new List<string>();
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase opcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                    if (opcoesBase != null && opcoesBase.UsarNoBancoDeDados && !opcoesBase.Identity)
                    {
                        campos.Add(pi.Name);
                        valores.Add(string.Concat("'", pi.GetValue(this), "'"));
                    }
                }
                string queryString = string.Concat("INSERT INTO ", this.GetType().Name, "s (", string.Join(",", campos.ToArray()), ") values(", string.Join(",", valores.ToArray()), ");");
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Busca todos
        /// </summary>
        /// <returns>Todos</returns>
        public List<IBase> Todos()
        {
            var list = new List<IBase>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string queryString = $"SELECT * FROM {this.GetType().Name}s";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var obj = (IBase)Activator.CreateInstance(this.GetType());
                    SetProperty(ref obj, reader);
                    list.Add(obj);
                }
            }
            return list;
        }

        /// <summary>
        /// SetProperty
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="reader"></param>
        private void SetProperty(ref IBase obj, SqlDataReader reader)
        {
            foreach (PropertyInfo pi in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                OpcoesBase opcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                if (opcoesBase != null && opcoesBase.UsarNoBancoDeDados)
                    pi.SetValue(obj, reader[pi.Name].ToString());
            }
        }
    }
}
