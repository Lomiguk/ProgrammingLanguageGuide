using System.ComponentModel.DataAnnotations;

namespace ProgrammingLanguageGuide.Context.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set;}
        //public long AuthorId {get; set;}
        //public Profile Author { get; set;}
        //public DateTime PostDateTime { get; set;}
        public string Content { get; set;}
        //public bool IsPrivate { get; set; }
        //public int ReadCount { get; set; }
        //public ICollection<Tag> Tags { get; set; }
    }
}
