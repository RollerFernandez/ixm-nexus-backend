namespace Ixm.Nexus.Commons.Configurations
{
    public class AppSettings
    {
        public DatabaseConfiguration DatabaseConfiguration { get; set; }
        public JwTokenConfiguration JWTokenConfiguration { get; set; }
        public NexusConfiguration NexusConfiguration { get; set; }
        public CacheConfiguration CacheConfiguration { get; set; }
    }
}
