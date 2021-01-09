using System;

namespace Database
{
    /// <summary>
    /// Opcoes de data anottations Base
    /// </summary>
    public class OpcoesBase : Attribute
    {
        /// <summary>
        /// Configura se usa no banco de dados
        /// </summary>
        public bool UsarNoBancoDeDados { get; set; }

        /// <summary>
        /// Configura se pode realizar buscas
        /// </summary>
        public bool UsarParaBuscar { get; set; }

        /// <summary>
        /// Define se é chave primaria
        /// </summary>
        public bool ChavePrimaria { get; set; }

        /// <summary>
        /// Define se a propriedade é auto increment(identity)
        /// </summary>
        public bool Identity { get; set; }
    }
}
