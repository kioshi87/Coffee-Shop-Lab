using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Models
{
    public class ItemsContext : DbContext
    {
        public ItemsContext (DbContextOptions<ItemsContext> options)
            : base(options)
        {
        }

        public DbSet<CoffeeShop.Models.Items> Items { get; set; }
    }
}
