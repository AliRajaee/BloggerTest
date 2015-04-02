using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogger.DataModel
{
    public class Blog
    {
        //private int _blogId;
        

        //public int BlogId 
        //{
        //    get { return _blogId; }
        //    set { _blogId = value; }
        //}
        public int BlogId { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Created { get; set;}
        public DateTime? LastUpdated { get; set; }
        public int BlogNo { get; set; }
    }
} 