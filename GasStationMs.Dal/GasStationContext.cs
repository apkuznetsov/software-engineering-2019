using GasStationMs.Dal.Entities;
using GasStationMs.Dal.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GasStationMs.Dal
{
    class GasStationContext : DbContext
    {
        public static readonly ILoggerFactory ConsoleLoggerFactory =
            new LoggerFactory().AddConsole(LogLevel.Information);

        public GasStationContext()
        {
        }

        public DbSet<Fuel> Fuels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(ConsoleLoggerFactory)
                .UseSqlServer("Server=.\\SQLEXPRESS; Initial Catalog=GasStationMs;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuelConfiguration());
        }
    }
}