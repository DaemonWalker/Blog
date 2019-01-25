using Blog.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data
{
    public interface ITagHelper
    {
        List<string> GetTags(int blogID);
        List<string> GetAllTags();
        List<string> SearchTags(string tagName);
        List<BlogModel> GetBlogIDs(string tag);
    }
}
