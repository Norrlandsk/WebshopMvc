using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages
{
    class LoginMessage
    {
        public static void Success(string userName)
        {
            Console.Clear();
            Console.WriteLine($"Welcome {userName}!");
            Prompts.ClearAndContinue();
        }
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong! Are you sure you typed in your user name and password correctly?");
            return Prompts.Abort();
        }
    }
}
