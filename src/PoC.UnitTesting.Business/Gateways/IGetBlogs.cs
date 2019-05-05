using System.Collections.Generic;
using PoC.UnitTesting.Business.Entities;

namespace PoC.UnitTesting.Business.Gateways
{
    /// <summary>
    /// Interface de busca de todos os blogs
    /// </summary>
    public interface IGetBlogs
    {
        /// <summary>
        /// Recupera todos os blogs
        /// </summary>
        /// <returns>Lista de blogs.</returns>
        IList<Blog> GetAll();         
    }
}