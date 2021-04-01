using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin.CategoryMessages
{
    public static class AddCategoryMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong when creating a category! Either your session timed out and you have to log in again, \n" +
                "or the category already exists");
            return Prompts.Abort();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("New category created!");
            Prompts.ClearAndContinue();
        }
    }
}
