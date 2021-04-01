using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin.CategoryMessages
{
    class UpdateCategoryMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong when updating the category! Either your session timed out and you have to log in again, \n" +
                "or the category Id was incorrect");
            return Prompts.Abort();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("Category updated!");
            Prompts.ClearAndContinue();
        }
    }
}
