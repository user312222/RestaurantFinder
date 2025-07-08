using Microsoft.EntityFrameworkCore;
using RestaurantFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantFinder.DataAccess
{
    public class RestaurantDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=W;Database=RestaurantDb;Integrated Security=True;TrustServerCertificate=True;");
        
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
