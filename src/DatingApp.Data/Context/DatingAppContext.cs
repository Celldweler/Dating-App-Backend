using DatingApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Data.Context
{
    public class DatingAppContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; }

        public DatingAppContext(DbContextOptions<DatingAppContext> options)
            : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseSqlite(Constants.SQLITE_CONNECTION_STRING);
            // optionsBuilder.UseInMemoryDatabase("Dev");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser { Id = 1, Username = "test" },
                new AppUser { Id = 2, Username = "raime" });
        }
    }
}
