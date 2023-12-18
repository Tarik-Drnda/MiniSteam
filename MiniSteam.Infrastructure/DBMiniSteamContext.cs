using Microsoft.EntityFrameworkCore;
using MiniSteam.Data;
using System.Configuration;

namespace MiniSteam.UX.Tools
{
    public class DBMiniSteamContext : DbContext
    {
        private readonly string db;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(db);
        }
        public DBMiniSteamContext()
        {
            db = ConfigurationManager.ConnectionStrings["DBMiniSteam"].ConnectionString;
        }

        
        public DbSet<User> Users { get; set; }
    
    }
}
