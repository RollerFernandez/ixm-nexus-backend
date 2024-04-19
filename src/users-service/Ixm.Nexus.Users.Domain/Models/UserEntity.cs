using Ixm.Nexus.Users.Domain.Commons;

namespace Ixm.Nexus.Users.Domain.Models
{
    
    public class UserEntity : Entity
    {
        //public string? Codigo { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        //public virtual ICollection<AlumnoCursoEntity> AlumnoCurso { get; set; }
        //public ICollection<MatriculaEntity> Matriculas { get; set; }
    }
}
