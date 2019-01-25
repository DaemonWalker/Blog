using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Blog.WebSite.Models
{
    [DataContract]
    public class ResultModel
    {
        [DataMember]
        public bool IsSuccess { get; set; }

        [DataMember]
        public string Message { set; get; }
    }
}
