using Database;
using System.Collections.Generic;

namespace Business
{
    /// <summary>
    /// Classe que representa o usuário
    /// </summary>
    public class Usuario : Base
    {

        /// <summary>
        /// Nome do usuários
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Nome { get; set; }

        /// <summary>
        /// Telefone do usuário
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        /// <summary>
        /// CPF do usuário
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true, ChavePrimaria = true, UsarParaBuscar = true)]
        public string CPF { get; set; }

        /// <summary>
        /// Lista de endereços
        /// </summary>
        public List<Endereco> Enderecos
        {
            get
            {
                List<Endereco> enderecos = new List<Endereco>();

                foreach (IBase ibase in new Endereco() { CPF = this.CPF }.Buscar())
                    enderecos.Add(item: (Endereco)ibase);

                return enderecos;
            }
        }

        /// <summary>
        /// Override ToString()
        /// </summary>
        /// <returns>Nome do usuário</returns>
        public override string ToString()
        {
            return Nome;
        }
    }
}
