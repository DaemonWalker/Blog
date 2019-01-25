using Blog.Data;
using Blog.Nosql;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Extenssion
{
    public static class DataExtenssion
    {
        public static void InjectDataHelper(this IServiceCollection service)
        {
            service.AddTransient(typeof(IAccountHelper), typeof(IAccountHelper));
            service.AddTransient(typeof(IBlogHelper), typeof(BlogHelper));
            service.AddTransient(typeof(IRemarkHelper), typeof(IRemarkHelper));
            service.AddTransient(typeof(ISummaryHelper), typeof(SummaryHelper));
            service.AddTransient(typeof(ITagHelper), typeof(TagHelper));
        }
    }
}
