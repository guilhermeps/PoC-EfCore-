using PoC.UnitTesting.Business.Entities;

namespace PoC.UnitTesting.Business.Gateways
{
    /// <summary>
    /// Interface de adição de blogs
    /// </summary>
    public interface IAddBlog
    {
        /// <summary>
        /// Realiza a adição de um blog
        /// </summary>
        /// <param name="blogToAdd">Blog a ser adicionado.</param>
        void Add(Blog blogToAdd);        
    }
}