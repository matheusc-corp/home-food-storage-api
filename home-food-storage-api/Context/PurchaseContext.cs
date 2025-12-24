using home_food_storage_api.Models;
using Microsoft.EntityFrameworkCore;

namespace home_food_storage_api.Context
{
    public class PurchaseContext : DbContext
    {
        public PurchaseContext(DbContextOptions<PurchaseContext> options) : base(options)
        {
            
        }

        public DbSet<PurchaseModel> Purchases { get; set; }
        public DbSet<ItemModel> Items { get; set; }
    }
}
