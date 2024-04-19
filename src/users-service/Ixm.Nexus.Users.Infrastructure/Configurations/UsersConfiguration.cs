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
            entityBuilder.Property(e => e.Codigo);
            Configure(entityBuilder);
        }

    }
}
