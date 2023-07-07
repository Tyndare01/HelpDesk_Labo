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
                    Passwd = user.Password

                };

                return connection.ExecuteScalar<User>(procedure, parameter, commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<bool> Delete(User user)
        //public bool Delete(int Id)
        {

            try
            {
                string sql = "Delete from Users Where Id_User = @Id";

                var param = new { ID = user.Id_User };
               int result = await connection.ExecuteAsync(sql, param);
                return result != 0 ? true : false; 
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
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
            string sql = "SELECT * FROM Users WHERE Id_User = @Id";

            var param = new { Id = Id };
            return await connection.QueryFirstAsync<User>(sql, param);

        }

        public async Task<bool> UpDatePassword(int id, string actualPasswd, string newPasswd)
        {
            try
            {
                var parameter = new { Id = id, ActualPasswd = actualPasswd,NewPasswd = newPasswd };

                string sql = "User_CheckPassword";

                int result = await connection.ExecuteAsync(sql, parameter, commandType: CommandType.StoredProcedure);

                return result == 1? true : false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
            
        }

        public User Update(User user)
        {
            try
            {
                string procedure = "User_Update";

                var parameter = new DynamicParameters();
                parameter.Add("@Id", user.Id_User);
                parameter.Add("@Email", user.Email);
                parameter.Add("@Firstname", user.FirstName);
                parameter.Add("@Lastname", user.LastName);
                parameter.Add("@Role", user.Role.ToString());
                


                User? userUpdated = connection.QueryFirst<User>(procedure, parameter, commandType: CommandType.StoredProcedure);

                return userUpdated;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }

}
