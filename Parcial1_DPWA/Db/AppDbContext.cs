using Microsoft.EntityFrameworkCore;
using Parcial1_DPWA.Models;

namespace Parcial1_DPWA.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opctions) : base(opctions)
        {

        }

        public DbSet<Faculties> Faculties { get; set; }
    }
}
