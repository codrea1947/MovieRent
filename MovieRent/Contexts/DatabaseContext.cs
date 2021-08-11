using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Contexts
{
    public class DatabaseContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses{get; set; }
        public DatabaseContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        { 
            options.UseSqlServer(Configuration.GetConnectionString("MovieRentDB"));
        }
    }
}
