using Microsoft.EntityFrameworkCore;
namespace Rocks.Models
{
    public class RockContext : DbContext
    {
        public RockContext() { }

        public RockContext(DbContextOptions<RockContext> options)
            : base(options)
        { }

        public DbSet<Rock> Rocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rock>().HasData(
                 new Rock
                 {
                     RockId = 1,
                     Color = "Polynesian",
                     Name = "Dwayne",
                     Shape = "Built/Muscular/Good",
                     Size = 77,
                     Weight = 300,
                     Home = "Hawaii",
                 },
                 new Rock
                 {
                     RockId = 2,
                     Color = "White",
                     Name = "Marbled Rock Roast",
                     Shape = "Meat",
                     Size = 1,
                     Weight = 800,
                     Home = "Death Mountain",
                 },
                 new Rock
                 {
                     RockId = 3,
                     Color = "White",
                     Name = "Christ the Redeemer",
                     Shape = "Christ",
                     Size = 1176,
                     Weight = 1400000,
                     Home = "Rio",
                 },
                 new Rock
                 {
                     RockId= 4,
                     Color = "Brown",
                     Name = "Parick's House",
                     Shape = "Boulder",
                     Size = 12,
                     Weight = 3,
                     Home = "Bikini Bottom",
                 }

             );
        }

    }
}
