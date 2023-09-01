using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultTenant.Models;

namespace MultTenant.Controllers
{
    public class TenantController : Controller
    {
        private readonly ILogger<TenantController> _logger;
        private readonly MultiTenantContext _context;

        public TenantController(ILogger<TenantController> logger, MultiTenantContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var tenants = await _context.Tenants.ToListAsync();
            return View(tenants);
        }

    }
}
