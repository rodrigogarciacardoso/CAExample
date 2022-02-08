using ArchitectureBase.Domain.Domain;
using ArchitectureBase.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureBase.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IAggregateRoot
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TEntity Update()
        {
            throw new NotImplementedException();
        }

        public TEntity Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
