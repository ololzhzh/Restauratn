using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesDomainAbstractions.Repositories;
using ResipesEntities.Code;

namespace RecipesRepositories.Abstract
{
    //Repository interfaces
    public interface IProductsRepository : IDbRepository<Product>
    {
    }
    public interface IRecipesRepository : IDbRepository<Recipe>
    {
    }
    public interface IDishesRepository : IDbRepository<Dish>
    {
    }
    public interface ICounteresRepository : IDbRepository<Counter>
    {
    }
}
