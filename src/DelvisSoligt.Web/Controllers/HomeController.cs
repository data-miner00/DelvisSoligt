using DelvisSoligt.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;

namespace DelvisSoligt.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Docs()
        {
            Span<byte> data = stackalloc byte[256];
            return View();
        }

        public IActionResult Showcase()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}