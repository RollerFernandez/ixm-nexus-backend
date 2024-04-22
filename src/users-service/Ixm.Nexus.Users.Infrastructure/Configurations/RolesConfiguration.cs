namespace Ixm.Nexus.Users.Infrastructure.Configurations
{
    public class RolesConfiguration : EntityConfiguration<RoleEntity>
    {
        public RolesConfiguration(ModelBuilder builder) 
        {
            var entityBuilder = builder.Entity<RoleEntity>();
            entityBuilder.ToTable("role");
            entityBuilder.HasKey(c => c.Id);
            entityBuilder.Property(e => e.Name).HasColumnName("nv_name");
            entityBuilder.Property(e => e.Id).HasColumnName("in_id").IsRequired();
            entityBuilder.Property(e => e.Name).HasColumnName("nv_name").IsRequired();
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
