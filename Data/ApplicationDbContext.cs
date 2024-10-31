using Microsoft.EntityFrameworkCore;
using VendorBiddingAppAPI.Models;

namespace VendorBiddingAppAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Vendor> vendors { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Bid> Bid {  get; set; }
    }
}
