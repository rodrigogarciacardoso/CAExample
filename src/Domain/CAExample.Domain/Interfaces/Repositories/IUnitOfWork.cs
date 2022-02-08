namespace ArchitectureBase.Domain.Interfaces.Repositories;

public interface IUnitOfWork
{
    Task<bool> Commit();
}