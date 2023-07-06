using Domain.Enums;

namespace BLL.Entities.ViewModel
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
