using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Services
{

    public class Helpers
    {
        public void WelcomeDialogue()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("               *******************************************************************************");
            Console.WriteLine("                                              Welcome to HabitTracker!                ");
            Console.WriteLine("");
            Console.WriteLine("                             Press 1 to Log In                         Press 2 to Register");
            Console.WriteLine("               *******************************************************************************");
            
        }
        
        public void StartBeep()
        {
          for(int i=0; i<=1; i++)
            {
                Console.Beep(1200, 500);
            }
            Console.Beep(1200, 900);

        }
        public void SuccessBeep()
        {
            Console.Beep(500, 200);
            Console.Beep(800, 200);
            Console.Beep(1100, 200);
        }
        public void ErrorBeep()
        {
            Console.Beep(1100, 400);
            Console.Beep(800, 400);
            Console.Beep(500, 400);
        }
        public void ErrorMsg(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void SuccessMsg(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            SuccessBeep();
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public int CheckInitilChoice(string number, int range)
        {
            int input = 0;
            bool isNumber = int.TryParse(number, out input);
            if (!isNumber)
            {
                ErrorMsg("You did not enter a number! Please enter a number!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if(input < 1 || input > range)
            {
                ErrorMsg("Your input is out of range, please try again!");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            return input;

        }
        public bool CheckString(string text, int range)
        {
            if (text.Length < range) return false;
            return true;
        }

        public bool CheckNumber (string input)
        {
            int n = 0;
            bool isNumber = int.TryParse(input, out n);
            if (isNumber) return true;
            return false;
        }
    }
}
