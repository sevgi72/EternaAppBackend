using EternaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Data
{
    public class EternaAppDbContext:DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feature> Features { get; set; }
        public EternaAppDbContext(DbContextOptions<EternaAppDbContext> options) : base(options)
        {
        }
    }
}
