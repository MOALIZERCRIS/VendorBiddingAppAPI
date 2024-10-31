using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VendorBiddingAppAPI.Data;
using VendorBiddingAppAPI.Models;

namespace VendorBiddingAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectListingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProjectListingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetProjects()
        {
            return await _context.projects.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Project>> CreateProject([FromBody] Project project)
        {
            _context.projects.Add(project);
            await _context.SaveChangesAsync();
            return Ok(project);
        }
    }
}
