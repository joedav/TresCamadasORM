using System.Collections.Generic;

namespace Database
{
    /// <summary>
    /// Interface base
    /// </summary>
    public interface IBase
    {
        /// <summary>
        /// Chave
        /// </summary>
        int Key { get; }

        /// <summary>
        /// Salvar
        /// </summary>
        void Salvar();

        List<IBase> Todos();

        List<IBase> Buscar();
    }
}
