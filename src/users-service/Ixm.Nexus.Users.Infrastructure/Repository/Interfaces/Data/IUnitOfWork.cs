using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ixm.Nexus.Users.Infrastructure.Repository.Interfaces.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();

        bool HasChanges();

        void Dispose(bool disposing);

        T Repository<T>() where T : class;

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbContext Get();
    }
}
