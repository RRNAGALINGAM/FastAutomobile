using Fast.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Fast.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // Table will created in this name given below "Brand"
        public DbSet<Brand> Brand { get; set; } 
    }
}
