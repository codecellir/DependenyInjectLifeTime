using InectionLifeTime.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InectionLifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IScopedOperation _scopedOperation;
        private readonly ITransientOperation _transientOperation;
        private readonly ISingletonOperation _singletonOperation;
        private readonly OperationService _operationService;
        public HomeController(ILogger<HomeController> logger,
            IScopedOperation scopedOperation,
            ITransientOperation transientOperation,
            ISingletonOperation singletonOperation,
            OperationService operationService)
        {
            _logger = logger;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
            _transientOperation = transientOperation;
            _operationService = operationService;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = _singletonOperation;
            ViewBag.Transient = _transientOperation;
            ViewBag.Scoped = _scopedOperation;
            ViewBag.Service = _operationService;
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