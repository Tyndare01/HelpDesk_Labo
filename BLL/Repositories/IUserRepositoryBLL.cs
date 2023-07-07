
using BLL.Entities.ViewModel;
using BLL.Entities.DTOs.User;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public interface IUserRepositoryBLL
    {
        public UserViewModel? Login(int Id, LoginDTO LoginDTO);
        
        public UserViewModel? Create(CreateUserDTO user);

        //public bool EmailAlreadyUsed(string email);

        Task<UserViewModel?> GetByEmail(string email);


        Task<UserViewModel?> GetById(int Id);


        Task<IEnumerable<UserViewModel>> GetAll(); // On peut pas avoir un tableau avec des users null

        Task <UserViewModel?> UpdateDatas(int Id, ChangeDataDTO changeDataDTO);

        Task<UserViewModel?> UpdateRole(int Id, ChangeRoleDTO changeRoleDTO);

        Task<bool> UpdatePassword(int Id, ChangePasswordDTO changePasswordDTO);


        //public bool Delete(int Id);

        public Task<bool> Delete (int Id);



    }
}
