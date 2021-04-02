using System;
using System.Collections.Generic;
using System.Text;
using WebshopAPI.Models;

namespace WebshopMVC.Views.Messages
{
    public static class LogoutMessage
    {
        public static void LoggedOut(User user)
        {
            Console.Clear();
            Console.WriteLine($"You have been logged out!\n\nHope to se you back soon, {user.Name}!");
            Prompts.ClearAndContinue();
        }  
    }
}
