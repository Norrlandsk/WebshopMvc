using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin.UserMessages
{
    static class BestCostumerMessage
    {
        public static void Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong when retrieving the best costumer! Either your session timed out and you have to log in again, \n" +
                "or the database is empty");

        }
    }
}
