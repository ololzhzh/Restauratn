using System;
using System.Collections.Generic;
using System.Linq;
using RecipesDataUnit;
using ResipesEntities.Code;

namespace FunctionsLibrary
{
    public class MyInterLayer
    {
        #region fields
        private Product _product;
        private Dish _dish;
        private Recipe _recipe;
        private List<Product> _listProduct = new List<Product>();
        private List<Dish> _dishes = new List<Dish>();
        private List<Counter> _listCounter = new List<Counter>();
        #endregion

        #region properties and indexer
        public List<Product> listProduct
        {
            get { return _listProduct; }
        }
        public string dim
        {
            get { return _product.Dimension; }
        }
        public string dishName
        {
            get { return _dish.Name; }
        }
        public string dishRecipe
        {
            get { return _dish.Recipe.TextRecipe; }
        }

        public List<string> dishProductsName

        {
            get
            {
                List<string> returnProducts = new List<string>();
                foreach (Product product in _dish.Recipe.Products)
                {
                    returnProducts.Add(product.Name);
                }
                return returnProducts;
            }
        }

        public List<string> dishProductsDim

        {
            get
            {
                List<string> returnProducts = new List<string>();
                foreach (Product product in _dish.Recipe.Products)
                {
                    returnProducts.Add(product.Dimension);
                }
                return returnProducts;
            }
        }

        public List<int> dishProductCounter
        {
            get
            {
                List<int> returnCounter = new List<int>();
                foreach (Counter counter in _dish.Recipe.Counts)
                {
                    returnCounter.Add(counter.counts);
                }
                return returnCounter;
            }
        }
        #endregion

        #region Methods

        public bool Add(string name, string dimension, int count)
        {
            return AddPrivate(name, dimension, count);
        }
        /// <summary>
        /// Add Product to the base.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dimension"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private bool AddPrivate(string name, string dimension, int count)
        {
            try
            {
                if (name.CompareTo(string.Empty) != 0 && dimension.CompareTo(string.Empty) != 0 && count!=0)
                {
                    if (MyProductsPrivate(name, count))
                    {
                        _product = new Product
                        {
                            Name = name,
                            Dimension = dimension,
                            Count = count
                        };
                        Unit.ProductsRepository.AddItem(_product);
                        return true;
                    }
                    else
                    {
                        _product.Count += count;
                        Unit.ProductsRepository.ChangeItem(_product);
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        
        public bool MyProducts(string name, int count, bool plusToRecipe=false)
        {
            return (MyProductsPrivate(name, count, plusToRecipe));
        }
        /// <summary>
        /// Checks the presence of the product in the database.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        /// <param name="plusToRecipe"></param>
        /// <returns></returns>
        private bool MyProductsPrivate(string name, int count, bool plusToRecipe = false)
        {
            
            if (name.CompareTo(string.Empty) != 0 && count != 0)
            {
            foreach (Product product in Unit.ProductsRepository.AllItems.ToList<Product>())
            {
                if (name.CompareTo(product.Name) == 0)
                {
                    _product = product;
                        if (plusToRecipe)
                        {
                            _listProduct.Add(product);
                            MakeCounter(count);
                        }
                    return false;
                }
            }
            return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Adds a number to the table "Counter".
        /// </summary>
        /// <param name="count"></param>
        public void MakeCounter(int count)
        {
            Counter counter = new Counter { counts = count };
            Unit.CounteresRepository.AddItem(counter);
            _listCounter.Add(counter);
        }
        public bool RecipeClear()
        {
            return (RecipeClearPrivate());
        }
        /// <summary>
        /// Clears the settings for adding a recipe.
        /// </summary>
        /// <returns></returns>
        private bool RecipeClearPrivate()
        {
            _listProduct.Clear();
            _listCounter.Clear();
            _product = null;
            return true;
        }

        public bool AddRecipe(string recipeName, string recipeText)
        {
            return AddRecipePrivate(recipeName, recipeText);
        }
        /// <summary>
        ///  Adds a recipe to the database.
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="recipeText"></param>
        /// <returns></returns>
        private bool AddRecipePrivate(string recipeName, string recipeText)
        {
            if (recipeName.CompareTo(string.Empty)!=0 && recipeText.CompareTo(string.Empty) != 0 && listProduct.Count>0)
            {
                if (MyDishesPrivate(recipeName))
                {
                    _recipe = new Recipe
                    {
                        Products = _listProduct,
                        TextRecipe = recipeText,
                        Counts = _listCounter,
                    };
                    Unit.RecipesRepository.AddItem(_recipe);
                    _dish = new Dish
                    {
                        Name = recipeName,
                        Recipe = _recipe
                    };
                    Unit.DishesRepository.AddItem(_dish);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool MyDishes(string dishName)
        {
            return MyDishesPrivate(dishName);
        }
        /// <summary>
        /// Checking the presence of dish in the database.
        /// </summary>
        /// <param name="dishName"></param>
        /// <returns></returns>
        private bool MyDishesPrivate(string dishName)
        {
            foreach (Dish dish in Unit.DishesRepository.AllItems.ToList<Dish>())
            {
                if (dishName.CompareTo(dish.Name) == 0)
                {
                    _dish = dish;
                    return false;
                }
            }
            return true;
        }
        public List<string> ReturnDishes()
        {
            return ReturnDishesPrivate();
        }
        /// <summary>
        /// Returns the list of all dishes.
        /// </summary>
        /// <returns></returns>
        private List<string> ReturnDishesPrivate()
        {
            List<string> nameDishes = new List<string>();
            foreach (Dish dish in Unit.DishesRepository.AllItems.ToList<Dish>())
            {
                _dishes.Add(dish);
                nameDishes.Add(dish.Name);
            }
            return nameDishes;
        }

        public bool Order(string orderDish, bool okey=false)
        {
            return OrderPrivate(orderDish, okey);
        }
        /// <summary>
        /// Function of selling dishes.
        /// </summary>
        /// <param name="orderDish"></param>
        /// <param name="okey"></param>
        /// <returns></returns>
        private bool OrderPrivate(string orderDish, bool okey = false)
        {
            if (!MyDishesPrivate(orderDish))
            {
                for(int i=0; i<_dish.Recipe.Products.Count; i++)
                {
                    if (_dish.Recipe.Products[i].Count < _dish.Recipe.Counts[i].counts)
                    {
                        return false;
                    }
                    else
                    {
                        if (okey)
                        {
                            _dish.Recipe.Products[i].Count -= _dish.Recipe.Counts[i].counts;
                            Unit.ProductsRepository.ChangeItem(_dish.Recipe.Products[i]);
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OrderRemove(string orderDish)
        {
            return OrderRemovePrivate(orderDish);
        }
        /// <summary>
        /// Function of canceling the sale of a dish.
        /// </summary>
        /// <param name="orderDish"></param>
        /// <returns></returns>
        private bool OrderRemovePrivate(string orderDish)
        {
            if (!MyDishesPrivate(orderDish))
            {
                for (int i = 0; i < _dish.Recipe.Products.Count; i++)
                {
                    _dish.Recipe.Products[i].Count += _dish.Recipe.Counts[i].counts;
                    Unit.ProductsRepository.ChangeItem(_dish.Recipe.Products[i]);
                }
            }
            else
            {
                return false;
            }
            return true;
        }
        public List<string> ReturnAllProducts()
        {
            return ReturnAllProductsPrivate();
        }
        /// <summary>
        /// Returns all products from the database.
        /// </summary>
        /// <returns></returns>
        private List<string> ReturnAllProductsPrivate()
        {
            List<string> returnProd = new List<string>();
            foreach (Product prod in Unit.ProductsRepository.AllItems.ToList<Product>())
            {
                returnProd.Add($"{prod.Name} - {prod.Count} {prod.Dimension} \r\n");
            }
            return returnProd;
        }
        /// <summary>
        /// Remove dishes from the database.
        /// </summary>
        /// <param name="dish"></param>
        /// <returns></returns>
        public bool DeleteDish(string dish)
        {
            if (!MyDishesPrivate(dish))
            {
                Unit.RecipesRepository.DeleteItem(_dish.Recipe.Id);
                Unit.DishesRepository.DeleteItem(_dish.Id);
                SavePrivate();
                return true;
            }
            return false;
        }
        public bool Save()
        {
            return SavePrivate();
        }
        /// <summary>
        /// Save changes to the database.
        /// </summary>
        public bool SavePrivate()
        {
            Unit.ProductsRepository.SaveChanges();
            Unit.RecipesRepository.SaveChanges();
            Unit.DishesRepository.SaveChanges();
            return true;
        }
        #endregion
    }
}
