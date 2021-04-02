using System;

namespace WebshopMVC.Views.Messages.Admin.UserMessages
{
    internal class ListAllUsersMessage
    {
        public static void Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong when retrieving the list of users! Either your session timed out and you have to log in again, \n" +
                "or the database is empty");
        }
    }
}