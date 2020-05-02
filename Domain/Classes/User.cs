using Domain.Classes.Enumerations;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Classes
{
    public class User
    {
        
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } 

        //public DateTime BornOn()
        //{
            
        //}

        public User()
        {
            Role = UserRole.User;
        }
        public User (string name, string surname, int dateofbirth, string username, string email, string password, UserRole role)
        {
            Name = name;
            LastName = surname;
            DateOfBirth = dateofbirth;
            Username = username;
            Email = email;
            Password = password;
            Role = role;
        }

    
    }
}
