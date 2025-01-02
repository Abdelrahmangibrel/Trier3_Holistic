using System.ComponentModel.DataAnnotations;

namespace Trier3_Holistic.Dtos
{
    public class BlogPostDto
    {
        [Required]
        public string BlogPostTitle { get; set; }
        public DateTime DateTime { get; set; }
        public List<int> numerofsubscribe { get; set; }
    }
}
