using Microsoft.EntityFrameworkCore;
using Trier3_Holistic.Models;

namespace Trier3_Holistic.AppDbContext
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<BlogPost> Blogs { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
    }
}
