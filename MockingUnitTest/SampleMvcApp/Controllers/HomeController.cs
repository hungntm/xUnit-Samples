using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleMvcApp.Core;
using SampleMvcApp.Models;
using System.Diagnostics;

namespace SampleMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetDataRepository _data;

        public HomeController(IGetDataRepository data)
        {
            _data = data;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string GetNameById(int id)
        {
            return _data.GetNameById(id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
