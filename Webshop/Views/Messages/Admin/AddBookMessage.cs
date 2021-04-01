using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin
{
    class AddBookMessage
    {
        public static void AdminNotLoggedIn()
        {
            Console.Clear();
            Console.WriteLine("Session limit reached!\n" +
                "Please login again");
            Prompts.ClearAndContinue();
        }

        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went when adding a book! Either your session timed out and you have to log in again, \n" +
                "or you entered incorrect data");
            return Prompts.Abort();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("Book added to inventory!");
            Prompts.ClearAndContinue();
        }
    }
}
