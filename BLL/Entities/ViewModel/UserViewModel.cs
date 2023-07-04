using Domain.Enums;

namespace API_HelpDesk_Labo.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }


        public string Firstname { get; set; }


        public string Lastname { get; set; }


        public string Email { get; set; }


        public Roles Role { get; set; }
    }
}
