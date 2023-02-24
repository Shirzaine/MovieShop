using Microsoft.EntityFrameworkCore;
using MovieShopApplication.Data;
using MovieShopApplication.Interfaces;
using System.Linq.Expressions;

namespace MovieShopApplication.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected MovieShopContext MovieShopContext { get; set; }
        public RepositoryBase(MovieShopContext movieShopContext)
        {
            MovieShopContext = movieShopContext;
        }
        public IQueryable<T> FindAll() => MovieShopContext.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            MovieShopContext.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => MovieShopContext.Set<T>().Add(entity);
        public void Update(T entity) => MovieShopContext.Set<T>().Update(entity);
        public void Delete(T entity) => MovieShopContext.Set<T>().Remove(entity);
    }
}
