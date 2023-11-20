using Microsoft.EntityFrameworkCore;
using PracriseMigra.Models;

namespace PracriseMigra.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<About> abouts { get; set; }

        public DbSet<Product> products { get; set; }

    }
}
