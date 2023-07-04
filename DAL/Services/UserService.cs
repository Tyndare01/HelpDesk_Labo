using DAL.Repositories;
using Dapper;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class UserService : IUserRepository
    {
        private readonly IDbConnection connection;

        public UserService(IDbConnection connection)
        {
            this.connection = connection;
        }

        public User? Create(User user)
        {
            try
            {
                string procedure = "User_Register";

                var parameter = new
                {
                    Email = user.Email,
                    Firstname = user.FirstName,
                    Lastname = user.LastName,
                    Role = user.Role,
                    Password = user.Password

                };

                return connection.ExecuteScalar<User>(procedure, parameter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public bool Delete(int Id)
        {

            try
            {
                string sql = "Delete from Users Where Id = @Id";

                var param = new { Id = Id };
                connection.QueryFirst<User>(sql, param);
                return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public bool EmailAlreadyUsed(string email)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

                var param = new { Email = email };
                var count = connection.QueryFirst<int>(sql, param);

                return count > 0;
            }
            catch (Exception)
            {
                throw new Exception("This email adress is already used");
            }

        }


        public async Task<IEnumerable<User>> GetAll()
        {
            string sql = "SELECT * FROM Users";
            return await connection.QueryAsync<User>(sql);

        }

        public async Task<User?> GetByEmail(string email)
        {
            string sql = "SELECT * FROM Users WHERE Email = @Email";

            var param = new { Email = email };
            return await connection.QueryFirstAsync<User>(sql, param);
        }

        public async Task<User?> GetById(int Id)
        {
            string sql = "SELECT * FROM Users WHERE Id = @Id";

            var param = new { Id = Id };
            return await connection.QueryFirstAsync<User>(sql, param);
        }

        public User? Update(User user)
        {
            try
            {
                string procedure = "User_Update";

                var parameter = new
                {
                    Id = user.Id,
                    Email = user.Email,
                    Firstname = user.FirstName,
                    Lastname = user.LastName,
                    Role = user.Role,
                    Password = user.Password

                };

                return connection.ExecuteScalar<User>(procedure, parameter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
