using ArchitectureBase.Domain.Domain;

namespace ArchitectureBase.Domain.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        T Update();
        T Add();
        void Delete();
        Task<T> Get(int id);
        Task<IList<T>> GetAll();
    }
}
