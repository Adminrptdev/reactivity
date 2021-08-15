using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options) {
            if (options is null)
            {
                throw new ArgumentNullException(nameof(options));
            }
        }

        public DbSet<Activity> Activities {get; set;}
    }
}