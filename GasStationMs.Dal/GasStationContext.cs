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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(ConsoleLoggerFactory)
                .UseSqlServer("Server=.\\SQLEXPRESS; Initial Catalog=GasStationMs;Integrated Security=True;");
        }
    }
}