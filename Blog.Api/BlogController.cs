using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Blogger.DataAccess;

namespace Blogger.Api
{
    public class BlogController : ApiController
    {
        public IEnumerable<Model.Blog> Get()
        {
            var db = new BlogContext();
            var query = from b in db.Blogs
                select new Api.Model.Blog()
                {
                    Author =  b.Author,
                    Name = b.Name,
                    Posts = (from p in b.Posts select p.Title).ToList()
                };
                        

            var blogs = query.ToList();
            return blogs;
        }


        //public Blog Get(int id)
        //{

        //    using (var db = new BlogContext())
        //    {
        //        var query = from b in db.Blogs
        //                    where b.BlogId == id
        //                    select b;

        //        var blog = query.FirstOrDefault();
        //        return blog;
        //    }
            
        //}

        //public void Put(Model.Blog blog)
        //{
        //    var context = new BlogContext();
        //    context.Blogs.Add(blog);
        //    context.SaveChanges();

        //}

        //public void Delete(int id)
        //{
        //    using (var db = new BlogContext())
        //    {
        //        var query = from b in db.Blogs
        //            where b.BlogId == id
        //            select b;
        //        var blog = query.FirstOrDefault();
        //        if (blog != null)
        //        {
        //            db.Blogs.Remove(blog);
        //            db.SaveChanges();
        //        }

        //    }
        //}
    }
}