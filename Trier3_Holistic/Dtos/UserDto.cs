using System.ComponentModel.DataAnnotations;
using Trier3_Holistic.Models;

namespace Trier3_Holistic.Dtos
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }
        [EmailAddress]
        public string UserEmail { get; set; }
        [Phone]
        public string Phone { get; set; }
        public List<BlogPostDto> Posts { get; set; }
        public RoleDto RoleDto { get; set; }

    }
}
