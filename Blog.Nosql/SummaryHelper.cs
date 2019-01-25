using Blog.Data;
using Blog.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Nosql
{
    public class SummaryHelper : ISummaryHelper
    {
        private IMongoCollection<BlogModel> collection = DataBase.Instance.GetCollection<BlogModel>();
        public List<SummaryModel> GetLatestBlogs()
        {
            collection.Find(new BlogModel(), new FindOptions() { });
        }

        public List<SummaryModel> GetMostPopularBlogs()
        {
            throw new NotImplementedException();
        }
    }
}
