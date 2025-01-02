using System.ComponentModel.DataAnnotations;

namespace Trier3_Holistic.Dtos
{
    public class RoleDto
    {
        [Required]
        public string RoleName { get; set; }
    }
}
