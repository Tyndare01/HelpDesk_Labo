using System.ComponentModel.DataAnnotations;

namespace API_HelpDesk_Labo.DTOs.User
{
    public class ChangeDataDTO
    {
        [MaxLength(50)]
        public string Firstname { get; set; }

        [MaxLength(50)]
        public string Lastname { get; set; }
    }
}
