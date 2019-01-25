using Blog.Data;
using Blog.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Nosql
{
    public class TagHelper : ITagHelper
    {
        public List<string> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public List<BlogModel> GetBlogIDs(string tag)
        {
            throw new NotImplementedException();
        }

        public List<string> GetTags(int blogID)
        {
            throw new NotImplementedException();
        }

        public List<string> SearchTags(string tagName)
        {
            throw new NotImplementedException();
        }
    }
}
