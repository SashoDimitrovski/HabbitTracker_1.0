using Domain.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Classes.Enumerations;


namespace Domain.Services
{
    public class UserService
    {
        private Helpers _helpers = new Helpers();

        private User[] Users;
        private User CurrentUser;
        public UserService ()
        {
            Users = new User[]
            {
                new User("Sasho", "Dimitrovski", 38, "sasodim", "sasodimitrovski1982@yahoo.com", "sasodim1", UserRole.User ),
                new User("Steve", "Harris", 64, "theboss", "steve.harris@imaiden.com", "boss1", UserRole.User ),
            };
        }
        public void LogInMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                     Select one of the following:");
            Console.WriteLine("");
            Console.WriteLine("                     **************************************************************   ");
            Console.WriteLine("                      1. My habits                                     2. Log Out");
            Console.WriteLine("");
            Console.WriteLine("                     **************************************************************");

        }
        public void RegisterMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********************************");
            Console.WriteLine("          Enter your name:                ");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("        Enter your surname:               ");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            string surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("    Enter your year of birth:             ");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            int year = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("    Enter your month of birth:             ");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            int month = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("    Enter your day of birth:             ");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            int day = int.Parse(Console.ReadLine());
            DateTime inputDate = new DateTime(year, month, day);
            Console.Clear();
            //DateOfBirth = inputDate;
            Console.WriteLine("********************************");
            Console.WriteLine("          Enter your username:                ");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            string username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("          Enter your email:                ");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            string email = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("********************************");
            Console.WriteLine("          Enter your password:                ");
            Console.WriteLine("");
            Console.WriteLine("********************************");
            string password = Console.ReadLine();
            Console.Clear();
        }
        public User CheckLogIn(string username, string password)
        {
            foreach (User user in Users)
            {
                if (user.Username == username && user.Password == password) return user;
                CurrentUser = user;
                return user;
            }
        }
        public bool CheckUsername(string username)
        {
            if (username.Length < 6) return false;
            return true;
        
        }
        public bool CheckPassword(string password)
        {
            if (password.Length < 6) return false;
            return true;
            int n = 0;
            bool isNum = int.TryParse(password, out n);
            if (isNum)
            {
                return true;
            }
            return false;
        }
        public bool CheckFirstName(string firstName)
        {
            if (!_helpers.CheckNumber(firstName) && firstName.Length < 2) return true;
            return false;
        }
        public bool CheckLastName(string surname)
        {
            if (!_helpers.CheckNumber(surname) && surname.Length < 2) return true;
            return false;
        }
    }
}
