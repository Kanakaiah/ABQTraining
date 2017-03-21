using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using ABQTraining.Repository;
using ABQTraining.Model;

namespace ABQTraining.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHostingEnvironment _appEnvironment;

        public HomeController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            var bible = new BibleContext(_appEnvironment.ContentRootPath);

            List<Chapter> chapters= bible.GetBook("Ephesians").Chapter;

            return View(chapters);
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

        public IActionResult Error()
        {
            return View();
        }
    }
}
