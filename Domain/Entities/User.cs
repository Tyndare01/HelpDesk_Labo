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

        public User(string email, string firstname, string lastname, string password)
        {
           
            Email = email;
            FirstName = firstname;
            LastName = lastname;
            Password = password;
            Role = Roles.Employee;

        }

        public int Id_User { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Roles Role { get; set; }

        public string? Password { get; set; }


    }
}
