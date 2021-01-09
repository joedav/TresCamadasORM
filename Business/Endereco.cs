using Database;

namespace Business
{
    /// <summary>
    /// Classe que representa o Endereços
    /// </summary>
    public class Endereco : Base
    {
        /// <summary>
        /// Logradouro
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Logradouro { get; set; }

        /// <summary>
        /// Numero
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Numero { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Cidade { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Estado { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [OpcoesBase(ChavePrimaria = true, UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string CPF { get; set; }
    }
}
