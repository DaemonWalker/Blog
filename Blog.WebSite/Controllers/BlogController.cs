using Blog.Data;
using Blog.Model;
using Blog.WebSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogHelper blogHelper;
        public BlogController(IBlogHelper blogHelper)
        {
            this.blogHelper = blogHelper;
        }

        public ResultModel Insert(BlogModel blog)
        {
            return null;
        }
    }
}