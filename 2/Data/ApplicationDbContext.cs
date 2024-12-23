using _2.Models;
using Microsoft.EntityFrameworkCore;

namespace _2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }
    }
}