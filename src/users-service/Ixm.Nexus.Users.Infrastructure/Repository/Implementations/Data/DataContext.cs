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
            builder.ApplyConfiguration(new RolesConfiguration(builder));
            builder.ApplyConfiguration(new PermissionsConfiguration(builder));
            builder.ApplyConfiguration(new UserRoleConfiguration(builder));
            builder.ApplyConfiguration(new RolePermissionConfiguration(builder));
        }

        public DbSet<UserEntity> UserEntity { get; set; }
        public DbSet<RoleEntity> RoleEntity { get; set; }
        public DbSet<PermissionEntity> PermissionEntity { get; set; }
        public DbSet<UserRoleEntity> UserRoleEntity { get; set; }
        public DbSet<RolePermissionEntity> RolePermissionEntity { get; set; }
    }
}
