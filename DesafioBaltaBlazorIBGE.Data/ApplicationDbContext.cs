using DesafioBaltaBlazorIBGE.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesafioBaltaBlazorIBGE.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Ibge> Ibges { get; set; } = null!;
    }
}
