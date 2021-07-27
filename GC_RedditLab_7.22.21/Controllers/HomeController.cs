using GC_RedditLab_7._22._21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GC_RedditLab_7._22._21.Controllers
{
    public class HomeController : Controller
    {
        private readonly RedditDAL _posts = new RedditDAL();


        public HomeController()
        {
            

        }

        public async Task<IActionResult> Index()
        {

            var posts = await _posts.GetRedditPosts();
            return View(posts);
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
    }
}
