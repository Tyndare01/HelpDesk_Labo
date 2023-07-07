using BLL.Entities.DTOs.User;
using BLL.Entities.ViewModel;
using Domain.Entities;

namespace BLL.Entities.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel ToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Id = user.Id_User,
                Email = user.Email,
                Firstname = user.FirstName,
                Lastname = user.LastName,
                Role = user.Role
            };

        }

        public static User ToUser(this CreateUserDTO userdto)
        {
            return new User(userdto.Email, userdto.Firstname, userdto.Lastname, userdto.Password);
        }

        public static IEnumerable<UserViewModel> ToUserViewModelsList(this IEnumerable<User> users)
        {
            List<UserViewModel> list = new List<UserViewModel>();
            foreach (var user in users)
            {
                list.Add(user.ToUserViewModel());

            }
            return list;
        }
    }
}
