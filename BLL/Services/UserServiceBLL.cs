using BLL.Entities.Mappers;
using BLL.Repositories;
using BLL.Repositories.DTOs.User;
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

        public User? Create(CreateUserDTO createUserDTO)
        {
            return _UserRepository.Create(createUserDTO.ToUser());
        }

        public bool Delete(int Id)
        {
            
        }

        public bool EmailAlreadyUsed(string email)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public User? Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
