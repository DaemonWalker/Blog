using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Blog.Model
{
    [DataContract]
    public class SummaryModel
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public List<string> Tags { get; set; }
    }
}
