using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Models;

namespace PurpleBuzz.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AboutIntroComponent> AboutIntroComponents { get; set; }
        public DbSet<ContactCreateSuccessComponent> ContactCreateSuccessComponents { get; set; }
        public DbSet<ContactCategoryComponent> ContactCategoryComponents { get; set; }
    }
}
