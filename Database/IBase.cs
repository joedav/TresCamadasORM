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

        /// <summary>
        /// Deletar
        /// </summary>
        void Deletar();

        /// <summary>
        /// Criar tabela
        /// </summary>
        void CriarTabela();

        List<IBase> Todos();

        List<IBase> Buscar();
    }
}
