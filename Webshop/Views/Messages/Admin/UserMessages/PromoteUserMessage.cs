using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin.UserMessages
{
    class PromoteUserMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong when promoting a user! Either your session timed out and you have to log in again, \n" +
                "or a user with that Id does not exist");
            return Prompts.Abort();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("User now have administrator privileges!");
            Prompts.ClearAndContinue();
        }
    }
}
