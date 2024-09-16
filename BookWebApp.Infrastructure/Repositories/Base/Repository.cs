using BookWebApp.Core.Interfaces.InfrastructureInterfaces.Base;
using System.Linq.Expressions;

namespace BookWebApp.Infrastructure.Repositories.Base
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private ApplicationContext _context;

        protected Repository(ApplicationContext context)
        {
            _context = context;
        }


        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetBySearch(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
