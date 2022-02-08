using ArchitectureBase.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureBase.Infra.Data.Context
{
    public class SqlServerDbContext : DbContext, IUnitOfWork
    {
    }
}
