using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Blog.Model
{
    [DataContract]
    public class BaseModel<T>
    {
        [BsonRepresentation(BsonType.ObjectId)]
        [DataMember]
        public string _id { get; set; }
        public static implicit operator FilterDefinition<T>(BaseModel<T> model)
        {
            return ConvertToBsonDocument(model);
        }

        public static implicit operator UpdateDefinition<T>(BaseModel<T> model)
        {
            return ConvertToBsonDocument(model);
        }

        private static BsonDocument ConvertToBsonDocument(BaseModel<T> model)
        {
            var dict = new Dictionary<string, object>();
            foreach (var prop in model.GetType().GetProperties())
            {
                var isNull = false;
                if (prop.PropertyType.IsValueType)
                {
                    if (prop.GetValue(model) != Activator.CreateInstance(prop.PropertyType))
                    {
                        isNull = true;
                    }
                }
                else
                {
                    if (prop.GetValue(model) == null)
                    {
                        isNull = true;
                    }
                }

                if (isNull == false)
                {
                    dict.Add(prop.Name, prop.GetValue(model));
                }
            }
            return new BsonDocument().AddRange(dict);
        }
    }
}
