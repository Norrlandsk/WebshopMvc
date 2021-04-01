using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin.CategoryMessages
{
    class AddBookToCategoryMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong when adding the book! Either your session timed out and you have to log in again, \n" +
                "or the book/category Id was incorrect");
            return Prompts.Abort();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("Book added to category!");
            Prompts.ClearAndContinue();
        }
    }
}
