using BLL.Entities.DTOs.User;
using BLL.Entities.Mappers;
using BLL.Entities.ViewModel;
using BLL.Repositories;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserServiceBLL : IUserRepositoryBLL
    {
        private readonly DAL.Repositories.IUserRepository _UserRepository;


        public UserServiceBLL(DAL.Repositories.IUserRepository userServiceBLL)
        {
            _UserRepository = userServiceBLL;
        }


        public UserViewModel? Login(int Id, LoginDTO LoginDTO)
        {
            throw new NotImplementedException();
        }

        public UserViewModel? Create(CreateUserDTO createUserDTO)
        {
            return _UserRepository.Create(createUserDTO.ToUser())?.ToUserViewModel();
        }

        public async Task<bool> Delete(int Id)
        {
            User? user = await _UserRepository.GetById(Id);

            return user is not null? await _UserRepository.Delete(user) : false;
        }


        public async Task<IEnumerable<UserViewModel>> GetAll()
        {
            return (await _UserRepository.GetAll()).ToUserViewModelsList(); 
        }

        public async Task<UserViewModel?> GetByEmail(string email)
        {
            return (await _UserRepository.GetByEmail(email))?.ToUserViewModel();
        }

        public async Task<UserViewModel?> GetById(int Id)
        {
            var user = await _UserRepository.GetById(Id);
            return user?.ToUserViewModel();
            //return (await _UserRepository.GetById(Id))?.ToUserViewModel();
        }

       

        public async Task <UserViewModel?> UpdateDatas(int Id, ChangeDataDTO changeDataDTO)
        {
            User? user =  await _UserRepository.GetById(Id);
            if (user != null) 
            {
                user.FirstName = changeDataDTO.Firstname;
                user.LastName = changeDataDTO.Lastname;
                
                return _UserRepository.Update(user)?.ToUserViewModel();
            }

            return null;
        }

        public async Task<bool> UpdatePassword(int Id, ChangePasswordDTO changePasswordDTO)
        {
           
              

                return await _UserRepository.UpDatePassword(Id, changePasswordDTO.ActualPassword, changePasswordDTO.NewPassword);
            

            
        }

        public async Task<UserViewModel?> UpdateRole(int Id, ChangeRoleDTO changeRoleDTO)
        {
            try
            {
                User? user = await _UserRepository.GetById(Id);
                if (user != null && Enum.IsDefined(typeof(Roles), changeRoleDTO.Role))
                {
                    user.Role = changeRoleDTO.Role;

                    return _UserRepository.Update(user)?.ToUserViewModel();
                }
                
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
}
