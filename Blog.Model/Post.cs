using System;

namespace Blogger.DataModel
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastUpdated { get; set; }
        public virtual Blogger.DataModel.Blog Blog { get; set; }
        public int BlogId { get; set; }

    }
}