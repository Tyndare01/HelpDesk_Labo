using BLL.Entities.DTOs.User;
using BLL.Entities.Mappers;
using BLL.Entities.ViewModel;
using BLL.Repositories;
using Domain.Entities;
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

        public UserViewModel? Create(CreateUserDTO createUserDTO)
        {
            return _UserRepository.Create(createUserDTO.ToUser())?.ToUserViewModel();
        }

        public bool Delete(int Id)
        {
            return false;
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
            return (await _UserRepository.GetById(Id))?.ToUserViewModel();
        }

        public UserViewModel? UpdateDatas(int id, ChangeDataDTO changeDataDTO)
        {
            throw new NotImplementedException();
        }
    }
}
