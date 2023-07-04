using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace API_HelpDesk_Labo.DTOs.User
{
    public class ChangeRoleDTO
    {
        [Required]
        public Roles Role { get; set; }
    }
}
