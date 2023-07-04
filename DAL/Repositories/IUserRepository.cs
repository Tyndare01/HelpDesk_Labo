using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IUserRepository
    {
        public User? Create(User user);

        public bool EmailAlreadyUsed(string email);

        Task<User?> GetByEmail(string email);


        Task<User?> GetById(int Id);


        Task<IEnumerable<User>> GetAll(); // On peut pas avoir un tableau avec des users null

        public User? Update(User user);

        public bool Delete(int Id);

    }
}
