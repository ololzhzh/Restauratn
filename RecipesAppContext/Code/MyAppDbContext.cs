using ResipesEntities.Code;
using System.Data.Entity;

namespace RecipesAppContext.Code
{
    public class MyAppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Counter> Counteres { get; set; }

        public MyAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }
        static MyAppDbContext()
        {
            Database.SetInitializer(new MyAppDbContextInitializer());
        }
    }
}
