using Microsoft.EntityFrameworkCore;

namespace Ixm.Nexus.Users.Infrastructure.Configurations.Base
{
    public interface IEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
    }
}
