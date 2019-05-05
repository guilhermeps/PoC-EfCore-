using System;

namespace PoC.UnitTesting.Business.Entities
{
    /// <summary>
    /// Abstração de posts em blogs.
    /// </summary>
    public class Post
    {
        public Guid PostId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        // Propriedades de relacionamento 

        public Guid BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}