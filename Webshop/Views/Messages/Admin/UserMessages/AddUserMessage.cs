using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin.UserMessages
{
    class AddUserMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong when adding a new user! Either your session timed out and you have to log in again, \n" +
                "or a user with that name already exists");
            return Prompts.Abort();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("New user created!");
            Prompts.ClearAndContinue();
        }
    }
}
