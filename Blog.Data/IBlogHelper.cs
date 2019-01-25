using Blog.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Data
{
    public interface IBlogHelper
    {
        void AddBlog(BlogModel blog);
        void DeleteBolg(BlogModel blog);
        void UpdateBlog(BlogModel blog);
        BlogModel GetBlog(string id);
    }
}
