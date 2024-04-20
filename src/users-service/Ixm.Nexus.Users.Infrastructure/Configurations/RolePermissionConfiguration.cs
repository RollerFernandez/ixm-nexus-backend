namespace Ixm.Nexus.Users.Infrastructure.Configurations
{
    public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermissionEntity>
    {
        public RolePermissionConfiguration(ModelBuilder builder) 
        {
            var entityBuilder = builder.Entity<RolePermissionEntity>();
            entityBuilder.ToTable("role_permission");
            entityBuilder.HasKey(c => new { c.RoleId, c.PermissionId });
            entityBuilder.Property(e => e.RoleId).HasColumnName("in_roleId").IsRequired();
            entityBuilder.Property(e => e.PermissionId).HasColumnName("in_permissionId").IsRequired();
            Configure(entityBuilder);
        }

        public void Configure(EntityTypeBuilder<RolePermissionEntity> builder)
        {

        }
    }
}
