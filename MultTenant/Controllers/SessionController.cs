using Microsoft.AspNetCore.Mvc;

namespace MultTenant.Controllers
{
    public class SessionController : Controller
    {
        private readonly ILogger<SessionController> _logger;

        public SessionController(ILogger<SessionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
