using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudDF3.Models;

namespace CrudDF3.Controllers
{
    public class HomeController : Controller
    {
        private readonly CrudDf3Context _context;

        public HomeController(CrudDf3Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var habitaciones = await _context.Habitaciones.ToListAsync();
            return View(habitaciones); // Pasamos las habitaciones a la vista
        }
    }
}
