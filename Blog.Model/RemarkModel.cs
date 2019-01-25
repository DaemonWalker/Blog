using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Blog.Model
{
    [DataContract]
    public class RemarkModel
    {
        [DataMember]
        public string Content { get; set; }

        [DataMember]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime Date { get; set; }

        [DataMember]
        public int Agree { get; set; }

        [DataMember]
        public int BlogID { get; set; }

        [DataMember]
        public int ReferID { get; set; }
    }
}
