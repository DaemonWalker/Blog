using Blog.Model;
using System;
using System.Collections.Generic;

namespace Blog.Data
{
    public interface ISummaryHelper
    {
        List<SummaryModel> GetLatestBlogs();
        List<SummaryModel> GetMostPopularBlogs();
    }
}
