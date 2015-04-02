using System.Collections.Generic;
using System.Data.Entity;
using Blogger.DataModel;
using MyBlog = Blogger.DataModel.Blog;

namespace Blogger.DataAccess
{
    public class BlogInitialiser: DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            ICollection<Post> aliPosts = new []
            {
                new Post() {Title = "Post 1", Content = "Content 1", Author = "Ali 1"}, 
                new Post() {Title = "Post 2", Content = "Content 2"}, 
                new Post() {Title = "Post 3"}
            };

            var blogs = new []
            {
                new MyBlog() {Author = "Ali1", Name = "Blog 1", Posts = aliPosts},
                new MyBlog() {Author = "Ali2", Name = "Blog 2"},
                new MyBlog() {Author = "Ali3", Name = "Blog 3"}
            };
            
            //blogs.Add(new MyBlog()
            //{
            //    Author = "Ali1",
            //    Name = "Blog 1"
            //});

            //blogs.Add(new MyBlog()
            //{
            //    Author = "Ali2",
            //    Name = "Blog 2"
            //});

            //blogs.Add(new MyBlog()
            //{
            //    Author = "Ali2",
            //    Name = "Blog 2"
            //});

            //blogs.Add(new MyBlog()
            //{
            //    Author = "Ali3",
            //    Name = "Blog 3"
            //});

            context.Blogs.AddRange(blogs);
            //context.Blogs.Add(blog);
            context.SaveChanges(); //commit to db
        }
    }
}