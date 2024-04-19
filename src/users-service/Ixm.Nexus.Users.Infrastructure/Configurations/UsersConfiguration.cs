namespace Ixm.Nexus.Users.Infrastructure.Configurations
{ 
    public class UsersConfiguration : EntityConfiguration<UserEntity>
    {
        public UsersConfiguration(ModelBuilder builder)
        {
            var entityBuilder = builder.Entity<UserEntity>();
            entityBuilder.ToTable("user");
            entityBuilder.HasKey(c => c.Id);
            entityBuilder.Property(e => e.Name).HasColumnName("nv_name");
            entityBuilder.Property(e => e.LastName).HasColumnName("nv_lastName");
            entityBuilder.Property(e => e.Id).HasColumnName("in_id").IsRequired();
            entityBuilder.Property(e => e.Name).HasColumnName("nv_name").IsRequired();
            entityBuilder.Property(e => e.LastName).HasColumnName("nv_lastName").IsRequired();
            entityBuilder.Property(e => e.Username).HasColumnName("nv_username").IsRequired();
            entityBuilder.Property(e => e.Password).HasColumnName("nv_password").IsRequired();
            entityBuilder.Property(e => e.Email).HasColumnName("nv_email").IsRequired();
            entityBuilder.Property(e => e.Phone).HasColumnName("nv_phone").IsRequired();
            entityBuilder.Property(e => e.IsLocked).HasColumnName("bl_isLocked").IsRequired();
            entityBuilder.Property(e => e.CreatedAt).HasColumnName("dt_createdAt").IsRequired();
            entityBuilder.Property(e => e.UpdatedAt).HasColumnName("dt_updatedAt");
            entityBuilder.Property(e => e.CreatedBy).HasColumnName("nv_createdBy").IsRequired();
            entityBuilder.Property(e => e.UpdatedBy).HasColumnName("nv_updatedBy");
            entityBuilder.Property(e => e.RowStatus).HasColumnName("ch_status").IsRequired();
            Configure(entityBuilder);
        }

    }
}
