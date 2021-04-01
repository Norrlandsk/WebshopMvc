using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin
{
    class UpdateBookMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went when updating the book! Either your session timed out and you have to log in again, \n" +
                "or you entered incorrect data");
            return Prompts.Abort();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("Book updated!");
            Prompts.ClearAndContinue();
        }
    }
}
