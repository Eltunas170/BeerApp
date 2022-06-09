using BeerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeerApp.Controllers
{
    public class BrandController : Controller
    {
        private readonly Pub2Context _context;

        public BrandController(Pub2Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index() 
            => View(await _context.Brands.ToListAsync());
    }
}
