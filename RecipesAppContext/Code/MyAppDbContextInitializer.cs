using System.Data.Entity;

namespace RecipesAppContext.Code
{
    public class MyAppDbContextInitializer : DropCreateDatabaseIfModelChanges<MyAppDbContext>
    {
        protected override void Seed(MyAppDbContext context)
        {

        }
    }
}
