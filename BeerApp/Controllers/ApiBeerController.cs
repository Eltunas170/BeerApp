using BeerApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBeerController : ControllerBase
    {
        private readonly Pub2Context _context;

        public ApiBeerController(Pub2Context context)
        {
            _context = context;
        }

        public async Task<List<Beer>> Get()
            => await _context.Beers.ToListAsync();
    }
}
