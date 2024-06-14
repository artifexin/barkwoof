using core.Entities;
using infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers // Corrected namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdController : ControllerBase
    {
        private readonly StoreContext _context;
#pragma warning disable IDE0290 // Use primary constructor
        public ProdController(StoreContext context)
#pragma warning restore IDE0290 // Use primary constructor
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() // Corrected method name
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) // Corrected parameter name
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
