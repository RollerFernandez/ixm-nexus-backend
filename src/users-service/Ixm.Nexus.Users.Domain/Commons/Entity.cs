namespace Ixm.Nexus.Users.Domain.Commons
{
    public class Entity
    {
        public int Id { get; set; }
        //public string CreationUser { get; set; }
        //public DateTime CreationDate { get; set; }
        //public string ModificationUser { get; set; }
        //public DateTime? ModificationDate { get; set; }
        //public bool RowStatus { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
