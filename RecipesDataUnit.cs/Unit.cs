using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesAppContext;
using RecipesRepositories;

namespace RecipesDataUnit.cs
{
    public static class Unit
    {
        static MyAppDbContext _context;
        public static IProductsRepository AuthorsRepository { get; private set; }
        public static IRecipesRepository BooksRepository { get; private set; }
        public static IDishesRepository CategoriesRepository { get; private set; }
    }
    static Unit()
    {
        _context = new MyAppDbContext("Recipes");
        ProductsRepository = new ProductsRepository(_context);
        RecipesRepository = new RecipesRepository(_context);
        DishesRepository = new DishesRepository(_context);
    }
}
