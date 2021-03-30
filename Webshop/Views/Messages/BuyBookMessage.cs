using System;

namespace WebshopMVC.Views.Messages
{
    internal class BuyBookMessage
    {
        public static void UserNotLoggedIn()
        {
            Console.WriteLine("You have to be logged in to buy a book!\n" +
                "Please login or register a new user.");
            Prompts.ClearAndContinue();
        }

        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went wrong with the purchase! Either your session timed out and you have to log in again, \n" +
                "or the book is out of stock. Are you sure you entered the correct book Id?");
            return Prompts.Abort();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine("Book purchased!");
            Prompts.ClearAndContinue();
        }
    }
}