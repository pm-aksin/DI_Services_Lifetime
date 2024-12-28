using DI_Services_Lifetime.Models;
using DI_Services_Lifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DI_Services_Lifetime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScopedGUIDService _scopedGUIDService1;
        private readonly IScopedGUIDService _scopedGUIDService2;
        private readonly ITransientGUIDService _transientGUIDService1;
        private readonly ITransientGUIDService _transientGUIDService2;
        private readonly ISingletonGUIDService _singletonGUIDService1;  
        private readonly ISingletonGUIDService _singletonGUIDService2;

        public HomeController(IScopedGUIDService scopedGUIDService1,
                              IScopedGUIDService scopedGUIDService2,
                              ITransientGUIDService transientGUIDService1,
                              ITransientGUIDService transientGUIDService2, 
                              ISingletonGUIDService singletonGUIDService1, 
                              ISingletonGUIDService singletonGUIDService2,
                              ILogger<HomeController> logger)
        {
            _scopedGUIDService1 = scopedGUIDService1;
            _scopedGUIDService2 = scopedGUIDService2;
            _transientGUIDService1 = transientGUIDService1;
            _transientGUIDService2 = transientGUIDService2;
            _singletonGUIDService1 = singletonGUIDService1;
            _singletonGUIDService2 = singletonGUIDService2;
            _logger = logger;
        }
        private readonly ILogger<HomeController> _logger;


        public IActionResult Index()
        {
            StringBuilder message = new StringBuilder();
            message.Append("Scoped 1: " + _scopedGUIDService1.GetGUID() + "\n");
            message.Append("Scoped 2: " + _scopedGUIDService2.GetGUID() + "\n");
            message.Append("Transient 1: " + _transientGUIDService1.GetGUID() + "\n");
            message.Append("Transient 2: " + _transientGUIDService2.GetGUID() + "\n");
            message.Append("Singleton 1: " + _singletonGUIDService1.GetGUID() + "\n");
            message.Append("Singleton 2: " + _singletonGUIDService2.GetGUID() + "\n");
            return Ok(message.ToString());
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
