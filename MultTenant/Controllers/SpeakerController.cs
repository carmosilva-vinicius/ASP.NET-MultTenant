using Microsoft.AspNetCore.Mvc;

namespace MultTenant.Controllers
{
    public class SpeakerController : Controller
    {
        private readonly ILogger<SpeakerController> _logger;

        public SpeakerController(ILogger<SpeakerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
