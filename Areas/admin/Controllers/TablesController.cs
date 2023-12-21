using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_16.Areas.admin.Models.Entities;
using Task_16.Context;

namespace Task_16.Areas.admin.Controllers
{
    [Area("Admin")]
    public class TablesController : Controller
    {
        readonly private Task16DbContext _context;
        public TablesController(Task16DbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<Statistics> statistics = await _context.Statistics.ToListAsync();
            return View(statistics);
        }
 
        public async Task<IActionResult> Details(string id)
        {
            var statistics = await _context.Statistics.FindAsync(Guid.Parse(id));
            if (statistics == null)
            {
                return NotFound();
            }
            return View(statistics);
        }
    }
}
