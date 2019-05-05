using System;
using System.Collections.Generic;

namespace PoC.UnitTesting.Business.Entities
{
    /// <summary>
    /// Abstração de blog.
    /// </summary>
    public class Blog
    {
        public Guid BlogId { get; set; }

        public string Url { get; set; }

        // Propriedades de relacionamento

        public ICollection<Post> Posts { get; set; }
    }
}