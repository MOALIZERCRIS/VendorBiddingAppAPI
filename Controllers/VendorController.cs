using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendorBiddingAppAPI.Data;
using VendorBiddingAppAPI.Models;

namespace VendorBiddingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VendorController(ApplicationDbContext context)
        {
            _context = context;

        }

        [HttpPost]
        public async Task<ActionResult<Vendor>> CreateVendor([FromBody] Vendor vendor)
        {
            _context.vendors.Add(vendor);
            await _context.SaveChangesAsync();
            return Ok(vendor);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor>> GetVendor(int id)
        {
            var vendor = await _context.vendors.FindAsync(id);
            return vendor == null ? NotFound() : Ok(vendor);
        }
    }
}
