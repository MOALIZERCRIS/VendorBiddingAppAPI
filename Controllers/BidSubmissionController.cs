using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendorBiddingAppAPI.Data;
using VendorBiddingAppAPI.Models;

namespace VendorBiddingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidSubmissionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BidSubmissionController(ApplicationDbContext context)
        {
             _context = context;
           
        }

        [HttpPost]
        public async Task<ActionResult<Bid>> SubmitBid([FromBody] Bid bid)
        {
            _context.Bid.Add(bid);
            await _context.SaveChangesAsync();
            return Ok(bid);
        }

        [HttpGet]
        public async Task<ActionResult<List<Bid>>> GetBids()
        {
            return await _context.Bid.ToListAsync();
        }
    }
}
