
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
        public UserViewModel? Create(CreateUserDTO user);

        //public bool EmailAlreadyUsed(string email);

        Task<UserViewModel?> GetByEmail(string email);


        Task<UserViewModel?> GetById(int Id);


        Task<IEnumerable<UserViewModel>> GetAll(); // On peut pas avoir un tableau avec des users null

        UserViewModel? UpdateDatas(int id, ChangeDataDTO changeDataDTO);



        public bool Delete(int Id);
    }
}
