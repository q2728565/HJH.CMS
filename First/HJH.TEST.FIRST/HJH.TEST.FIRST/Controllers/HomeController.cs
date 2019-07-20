using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HJH.TEST.FIRST.Models;
using HJH.TEST.FIRST.MODEL;
using Microsoft.Extensions.Options;

namespace HJH.TEST.FIRST.Controllers
{
    public class HomeController : Controller
    {
        private readonly Content _content;
        public HomeController(IOptions<Content> content)
        {
            _content = content.Value;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Content()
        {
            //List<Content> list = new List<Content>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    list.Add(new Content
            //    {
            //        Id = i,
            //        Title = $"标题{i}",
            //        Text = $"这是第{i}个文本",
            //        CreateTime = DateTime.Now.AddDays(-i)
            //    });
            //}
            ViewData["title"] = "测试列表";
            return View(new ContentViewModel { content_list = new List<Content> { _content } });
        }
    }
}
