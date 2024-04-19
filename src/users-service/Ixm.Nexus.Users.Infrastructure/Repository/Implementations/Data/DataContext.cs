using Ixm.Nexus.Users.Infrastructure.Configurations;

namespace Ixm.Nexus.Users.Infrastructure.Repository.Implementations.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsersConfiguration(builder));
        }

        public DbSet<UserEntity> UserEntity { get; set; }
    }
}
