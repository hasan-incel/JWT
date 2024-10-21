using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using JWT.Entities;

namespace JWT.Contexts
{
    public class JwtDbContext : IdentityDbContext<IdentityUser>
    {
        public JwtDbContext(DbContextOptions<JwtDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
