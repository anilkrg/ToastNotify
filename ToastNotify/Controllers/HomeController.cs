using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToastNotify.Models;

namespace ToastNotify.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INotyfService _notfy;

        public HomeController(ILogger<HomeController> logger, INotyfService notyfService)
        {
            _logger = logger;
            _notfy = notyfService;
        }

        public IActionResult Index()
        {
            _notfy.Success("Registration completed sucessfully",3);
            _notfy.Error("Registration completed sucessfully", 3);
            _notfy.Warning("Registration completed sucessfully", 3);
            _notfy.Information("Registration completed sucessfully", 3);
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
    }
}
