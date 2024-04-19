namespace Ixm.Nexus.Users.Infrastructure.Configurations.Base
{
    public abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property("Id").HasColumnName("in_id");
            builder.Property("Status").HasColumnName("ch_status");
        }
    }
}
