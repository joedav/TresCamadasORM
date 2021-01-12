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

        public int Key
        {
            get
            {
                // this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                // -> Obtém uma lista de propriedades tanto públicas quanto instância
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase opcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                    if (opcoesBase != null && opcoesBase.ChavePrimaria)
                        return Convert.ToInt32(pi.GetValue(this));
                }
                return 0;
            }
        }

        /// <summary>
        /// Criar tabela
        /// </summary>
        public void CriarTabela()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string chavePrimaria = "";
                List<string> campos = new List<string>();
                foreach (PropertyInfo pi in this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    OpcoesBase opcoesBase = (OpcoesBase)pi.GetCustomAttribute(typeof(OpcoesBase));
                    if (opcoesBase != null && opcoesBase.UsarNoBancoDeDados)
                    {
                        if (opcoesBase.ChavePrimaria)
                        {
                            chavePrimaria = pi.Name + " int identity, ";
                        }
                        else
                        {
                            campos.Add(string.Concat(pi.Name, " " + TipoPropriedade(pi)));
                        }
                    }
                }

                string tabelaExist = "IF EXISTS (SELECT * FROM dbo.sysobjects WHERE ID = OBJECT_ID(N'[dbo].[" + this.GetType().Name + "s]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)"
                    + "DROP TABLE " + this.GetType().Name + "s;";
                SqlCommand cmd = new SqlCommand(tabelaExist, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                string queryString = $"CREATE TABLE {this.GetType().Name}s (";
                queryString += chavePrimaria;
                queryString += string.Join(", ", campos.ToArray()) + ");";

                SqlCommand cmdTable = new SqlCommand(queryString, conn);
                cmdTable.Connection.Open();
                cmdTable.ExecuteNonQuery();
                cmdTable.Connection.Close();
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
                        if (Key == 0)
                        {
                            campos.Add(pi.Name);
                            valores.Add(string.Concat("'", pi.GetValue(this), "'"));
                        }
                        else
                        {
                            valores.Add(string.Concat(pi.Name, " = '", pi.GetValue(this), "'"));
                        }
                    }
                }



                string queryString = "";
                if (Key == 0)
                {
                    queryString = string.Concat("INSERT INTO ", this.GetType().Name, "s (", string.Join(",", campos.ToArray()), ") values(", string.Join(",", valores.ToArray()), ");");
                }
                else
                {
                    queryString = string.Concat("UPDATE ", this.GetType().Name, "s SET ", string.Join(",", valores.ToArray()), " WHERE ID =", Key, ";");
                }


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
        public virtual List<IBase> Todos()
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

        public virtual void Deletar()
        {
            if (Key != 0)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    string queryString = $"DELETE FROM {this.GetType().Name}s WHERE Id = '{Key}';";
                    SqlCommand cmd = new SqlCommand(queryString, conn);
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            }
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
                    pi.SetValue(obj, reader[pi.Name]);
            }
        }


        /// <summary>
        /// Retorna o tipo da propriedade
        /// </summary>
        /// <returns></returns>
        private string TipoPropriedade(PropertyInfo pi)
        {
            switch (pi.PropertyType.Name)
            {
                case "Int32":
                    return "int";
                case "Int64":
                    return "bigint";
                case "Double":
                    return "decimal(9,2)";
                case "Single":
                    return "float";
                case "Boolean":
                    return "bit";
                default:
                    return "varchar(255)";
            }
        }
    }
}
