using System;
using System.Collections.Generic;

namespace Blogger.Api.Model
{
    public class Blog
    {        
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public ICollection<string> Posts { get; set; }
        public DateTime Created { get; set;}
        public DateTime LastUpdated { get; set; }
        public int BlogNo { get; set; }
    }
} 