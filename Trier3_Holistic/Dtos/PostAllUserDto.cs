using System.ComponentModel.DataAnnotations;
using Trier3_Holistic.Models;

namespace Trier3_Holistic.Dtos
{
    public class PostAllUserDto
    {
        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        public string UserEmail { get; set; }
        [Phone]
        public string Phone { get; set; }
        public List<BlogPostDto> BlogPostDto { get; set; }
        public int RoleId { get; set; }

        public RoleDto RoleDto { get; set; }
    }
}
