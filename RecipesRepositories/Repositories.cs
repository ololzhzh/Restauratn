using RecipesAppContext.Code;
using ResipesEntities.Code;
using RecipesRepositories.Generic;
using RecipesRepositories.Abstract;

namespace RecipesRepositories
{
    public class ProductsRepository : DbRepository<Product>, IProductsRepository
    {
        public ProductsRepository(MyAppDbContext context)
            : base(context)
        {
        }
    }

    public class RecipesRepository : DbRepository<Recipe>, IRecipesRepository
    {
        public RecipesRepository(MyAppDbContext context)
            : base(context)
        {
        }
    }

    public class DishesRepository : DbRepository<Dish>, IDishesRepository
    {
        public DishesRepository(MyAppDbContext context)
            : base(context)
        {
        }
    }

    public class CounteresRepository : DbRepository<Counter>, ICounteresRepository
    {
        public CounteresRepository(MyAppDbContext context)
            : base(context)
        {
        }
    }
}
