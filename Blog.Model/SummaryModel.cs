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

        public static implicit operator SummaryModel(BlogModel blog)
        {
            return new SummaryModel()
            {
                Title = blog.Title,
                Tags = blog.Tags,
                Summary = blog.Content.Substring(Math.Min(blog.Content.Length, 20))
            };
        }
    }
}
