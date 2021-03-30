using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages
{
    static class RegisterMessage
    {
        public static void Success(string userName,string password)
        {
            Console.Clear();
            Console.WriteLine($"You are now registered! Your user name is \"{userName}\" and your password is \"{password}\"\n");
            Console.WriteLine("Login to start buying books!");
            Prompts.ClearAndContinue();
        }
        public static string Error()
        {

            Console.Clear();
            Console.WriteLine("Something went wrong! Either the user name is already taken, or the password verification failed.");
            return Prompts.Abort();
        }
    }
}
