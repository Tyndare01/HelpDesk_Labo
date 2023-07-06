using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BLL.Entities.DTOs.User
{
    public class ChangeRoleDTO
    {
        [Required]
        public Roles Role { get; set; }
    }
}
