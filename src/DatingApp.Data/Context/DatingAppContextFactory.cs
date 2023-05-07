using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DatingApp.Data.Context
{
    public class DatingAppContextFactory : IDesignTimeDbContextFactory<DatingAppContext>
    {
        public DatingAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatingAppContext>();
            optionsBuilder.UseSqlite(Constants.SQLITE_CONNECTION_STRING);

            return new DatingAppContext(optionsBuilder.Options);
        }
    }
}