using Database;

namespace Business
{
    /// <summary>
    /// Classe Fornecedor
    /// </summary>
    public class Fornecedor : Base
    {
        /// <summary>
        /// Id do fornecedor
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, ChavePrimaria = true, Identity = true)]
        public int? Id { get; set; }

        /// <summary>
        /// Nome do Fornecedor
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Nome { get; set; }

        /// <summary>
        /// Telefone do Fornecedor
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Telefone { get; set; }

        /// <summary>
        /// Especialidades do Fornecedor
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Especialidades { get; set; }
    }
}
