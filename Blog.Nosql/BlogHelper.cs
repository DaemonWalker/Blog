using Blog.Data;
using Blog.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Nosql
{
    public class BlogHelper : IBlogHelper
    {
        private IMongoCollection<BlogModel> collection = DataBase.Instance.GetCollection<BlogModel>();
        public void AddBlog(BlogModel blog)
        {
            this.collection.InsertOne(blog);
        }

        public void DeleteBolg(BlogModel blog)
        {
            this.collection.DeleteOne(blog);
        }

        public BlogModel GetBlog(string id)
        {
            return this.collection.Find(new BlogModel() { _id = id }).FirstOrDefault();
        }

        public void UpdateBlog(BlogModel blog)
        {
            this.collection.UpdateOne(new BlogModel() { _id = blog._id }, blog);
        }
    }
}
