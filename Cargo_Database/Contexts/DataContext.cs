using Cargo_Database.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Cargo_Database.Contexts
{
    internal class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<CargoEntity> Cargo { get; set; }
        public DbSet<CisternEntity> Cistern { get; set;}
        public DbSet<CisternMeasureEntity> CisternMeasure { get; set; }
        public DbSet<VesselEntity> Vessel {  get; set; }
    }
}
