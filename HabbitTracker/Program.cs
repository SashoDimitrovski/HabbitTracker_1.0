using System;
using Domain.Services;



namespace HabbitTracker
{

    
    class Program
    {
        private static Helpers _helpers = new Helpers();
        private static UserService _userService = new UserService();
        static void Main(string[] args)
        {
            while (true)
            {
                int inputNum;
                while (true)
                {
                    _helpers.WelcomeDialogue();
                    _helpers.StartBeep();
                    inputNum = _helpers.CheckInitilChoice(Console.ReadLine(), 2);
                    if (inputNum == -1) continue;
                    break;
                    
                }

                if(inputNum == 1)
                {
                    while (true)
                    {
                        Console.Clear();
                        _helpers.SuccessMsg("You have successfully logged in.");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        _userService.LogInMenu();

                        Console.ReadLine();

                    }
                }
                if(inputNum == 2)
                {
                    while (true)
                    {
                        Console.Clear();
                        _userService.RegisterMenu();
                        _helpers.SuccessBeep();
                    }
                }

                
            }
        }
    }
}
