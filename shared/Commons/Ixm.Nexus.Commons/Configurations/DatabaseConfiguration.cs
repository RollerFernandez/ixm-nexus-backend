namespace Ixm.Nexus.Commons.Configurations
{
    public class DatabaseConfiguration
    {
        public Postgres Postgres { get; set; }
    }

    public partial class Postgres
    {
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public partial class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
    }
}
