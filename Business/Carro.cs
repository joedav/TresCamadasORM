using Database;

namespace Business
{
    /// <summary>
    /// Classe que representa o Endereços
    /// </summary>
    public class Carro : Base
    {
        /// <summary>
        /// Id
        /// </summary>
        [OpcoesBase(ChavePrimaria = true, UsarNoBancoDeDados = true, UsarParaBuscar = true, Identity = true)]
        public int Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Nome { get; set; }

        /// <summary>
        /// Marca
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public string Marca { get; set; }

        /// <summary>
        /// Valor
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public double Valor { get; set; }

        /// <summary>
        /// Quantidade
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public int Quantidade { get; set; }

        /// <summary>
        /// Disponibilidade
        /// </summary>
        [OpcoesBase(UsarNoBancoDeDados = true)]
        public bool Disponivel { get; set; }
    }
}
