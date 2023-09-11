using Microsoft.EntityFrameworkCore;
using StardewGuide.Models;

namespace StardewGuide.Data
{
    public class FarmDbContext : DbContext
    {
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Villager> Villagers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<BestGifts> BestGifts { get; set; } //type??

        public FarmDbContext(DbContextOptions<FarmDbContext> options) : base(options)
        {
        }
    }
}