using Microsoft.EntityFrameworkCore;
using NetCoreFlixWEBUI.Entities;
using NetCoreFlixWEBUI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreFlixWEBUI.DataAccess.Concrete
{
    public class NetCoreFlixContext : DbContext
    {

        //public NetCoreFlixContext(DbContextOptions<NetCoreFlixContext> options):base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NetCoreFlix; Trusted_Connection=true");
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<MovieCategory> MovieCategories { get; set; }


    }
}
