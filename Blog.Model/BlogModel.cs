using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Blog.Model
{
    [DataContract]
    public class BlogModel : BaseModel<BlogModel>
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }

        [DataMember]
        public string Contract { get; set; }

        [DataMember]
        public int Read { get; set; }

    }
}
