using System.ComponentModel.DataAnnotations;

namespace Trier3_Holistic.Models
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }
        [Required]
        public string BlogPostTitle { get; set; }
        public DateTime DateTime { get; set; }
        public List<int> numerofsubscribe {  get; set; }
        public User User { get; set; }
    }
}
