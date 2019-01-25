using Blog.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Nosql
{
    class DataBase
    {
        public static DataBase Instance { get; } = new DataBase();
        private MongoClient client;
        private IMongoDatabase db;
        private DataBase()
        {
            client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("blog");
        }
        public IMongoCollection<T> GetCollection<T>()
        {
            return db.GetCollection<T>(typeof(T).Name.Replace("Model", ""));
        }
    }
}
