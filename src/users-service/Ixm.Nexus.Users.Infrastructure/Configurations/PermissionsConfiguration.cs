namespace Ixm.Nexus.Users.Infrastructure.Configurations
{
    public class PermissionsConfiguration : EntityConfiguration<PermissionEntity>
    {
        public PermissionsConfiguration(ModelBuilder builder) 
        {
            var entityBuilder = builder.Entity<PermissionEntity>();
            entityBuilder.ToTable("permission");
            entityBuilder.HasKey(c => c.Id);
            entityBuilder.Property(e => e.Id).HasColumnName("in_id").IsRequired();
            entityBuilder.Property(e => e.Description).HasColumnName("nv_description").IsRequired();
            entityBuilder.Property(e => e.CreatedAt).HasColumnName("dt_createdAt").IsRequired();
            entityBuilder.Property(e => e.UpdatedAt).HasColumnName("dt_updatedAt");
            entityBuilder.Property(e => e.CreatedBy).HasColumnName("nv_createdBy").IsRequired();
            entityBuilder.Property(e => e.UpdatedBy).HasColumnName("nv_updatedBy");
            entityBuilder.Property(e => e.Status).HasColumnName("ch_status").IsRequired();
            Configure(entityBuilder);
        }
    }
}
