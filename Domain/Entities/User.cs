using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class User
    {
        public User() 
        {
            
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
            Role = Roles.Employee;

        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Roles Role { get; set; }

        public string? Password { get; set; }


    }
}
