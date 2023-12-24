using Microsoft.EntityFrameworkCore;
using TravelTask.Models;


namespace TravelTask.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(IConfiguration config)
        {
            Config = config;
        }

        public IConfiguration Config { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Config["ConnectionStrings: MSSql"]);
        }
        public DbSet<Product> Products { get; set; }
    }
}
