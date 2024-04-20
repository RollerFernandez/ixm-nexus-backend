
namespace Ixm.Nexus.Users.Infrastructure.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRoleEntity>
    {
        public UserRoleConfiguration(ModelBuilder builder) 
        {
            var entityBuilder = builder.Entity<UserRoleEntity>();
            entityBuilder.ToTable("user_role");
            entityBuilder.HasKey(c => new { c.UserId, c.RoleId });
            entityBuilder.Property(e => e.UserId).HasColumnName("in_userId").IsRequired();
            entityBuilder.Property(e => e.RoleId).HasColumnName("in_roleId").IsRequired();
            Configure(entityBuilder);
        }

        public void Configure(EntityTypeBuilder<UserRoleEntity> builder)
        {
            
        }
    }
}
