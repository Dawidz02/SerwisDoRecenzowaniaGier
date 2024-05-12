using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AplikacjaWebowa2_lab4.Components;

namespace AplikacjaWebowa2_lab4.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<AplikacjaWebowa2_lab4.Components.Game> Game { get; set; } = default!;
    }
}
