using Ixm.Nexus.Users.Domain.Commons;

namespace Ixm.Nexus.Users.Domain.Models
{
    
    public class UserEntity : Entity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsLocked { get; set; }
        //public virtual ICollection<AlumnoCursoEntity> AlumnoCurso { get; set; }
        //public ICollection<MatriculaEntity> Matriculas { get; set; }
    }
}
