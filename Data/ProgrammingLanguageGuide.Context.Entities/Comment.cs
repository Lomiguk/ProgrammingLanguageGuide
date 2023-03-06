using System.ComponentModel.DataAnnotations;

namespace ProgrammingLanguageGuide.Context.Entities
{
    public class Comment: BaseEntity
    {
        public long RepliComment { get; set;}
        public Profile Author { get; set;}
        public Article Article { get; set;}
        public string Content { get; set; }
        public DateTime CommentDateTime { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
    }
}
