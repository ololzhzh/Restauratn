using RecipesAppContext.Code;
using RecipesDomainAbstractions.Entities;
using RecipesDomainAbstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecipesRepositories.Generic
{
    public class DbRepository<T> : IDbRepository<T>
        where T : class, IDbEntity
    {
        #region Fields
        private MyAppDbContext _context;
        #endregion
        #region Properties and indexer
        public DbRepository(MyAppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> AllItems
        {
            get
            {
                return _context.Set<T>();
            }
        }
        #endregion
        #region Methods
        /// <summary>
        /// Add Item to the Base.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddItem(T item)
        {
            _context.Set<T>().Add(item);
            return SaveChanges();
        }
        /// <summary>
        /// Add array of items to the Base.
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool AddItems(IEnumerable<T> items)
        {
            _context.Set<T>().AddRange(items);
            return SaveChanges();
        }
        /// <summary>
        /// Change item in the Base.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool ChangeItem(T item)
        {
            T changed = GetItem(item.Id);
            //if (changed == null) return false;
            changed = item;
            return true;
        }
        /// <summary>
        /// Delete item from the Base.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteItem(Guid id)
        {
            T item = GetItem(id);
            _context.Set<T>().Remove(item);
            return true;
        }
        /// <summary>
        /// Receives item from the Base.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetItem(Guid id)
        {
            return AllItems.FirstOrDefault(x => x.Id.Equals(id));
        }
        /// <summary>
        /// Save changes in the Base.
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
#pragma warning disable 0168
            catch (Exception e)
#pragma warning restore 0168
            {
                return false;
            }
        }
        #endregion
    }
}
