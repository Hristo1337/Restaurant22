using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;

namespace Restaurant.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext (DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurant.Models.Table> Table { get; set; } = default!;
    }
}
