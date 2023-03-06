using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProgrammingLanguageGuide.Context.Entities
{
    [Index("Uid", IsUnique=true)]
    public class BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual long Id { get; set; }
        [Required]
        public virtual Guid Uid { get; set;} = Guid.NewGuid();
    }
}
