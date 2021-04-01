using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin
{
    class SoldItemsMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went when retrieving data from the database! Either your session timed out and you have to log in again, \n" +
                "or the database is empty");
            return Prompts.Abort();
        }
    }
}
