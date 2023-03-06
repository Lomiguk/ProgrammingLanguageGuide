using System.ComponentModel.DataAnnotations;

namespace ProgrammingLanguageGuide.Context.Entities
{
    public class Profile : BaseEntity
    {
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Profile> Subscibes { get; set; }
    }
}
