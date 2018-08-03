using RecipesAppContext.Code;
using RecipesRepositories;
using RecipesRepositories.Abstract;

namespace RecipesDataUnit
{
    public static class Unit
    {
        static MyAppDbContext _context;
        public static IProductsRepository ProductsRepository { get; private set; }
        public static IRecipesRepository RecipesRepository { get; private set; }
        public static IDishesRepository DishesRepository { get; private set; }

        public static ICounteresRepository CounteresRepository { get; private set; }

        static Unit()
        {
            _context = new MyAppDbContext("Recipes");
            ProductsRepository = new ProductsRepository(_context);
            RecipesRepository = new RecipesRepository(_context);
            DishesRepository = new DishesRepository(_context);
            CounteresRepository = new CounteresRepository(_context);
        }
    }
}
