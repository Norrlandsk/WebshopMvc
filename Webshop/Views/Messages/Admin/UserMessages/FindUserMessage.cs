using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin.UserMessages
{
    class FindUserMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong when retrieving users! Either your session timed out and you have to log in again, \n" +
                "or there were no matches for your search term");
            return Prompts.Abort();
        }
    }
}
