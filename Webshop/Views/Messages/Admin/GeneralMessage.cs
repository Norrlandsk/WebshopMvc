using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin
{
    class GeneralMessage
    {
        public static void AdminNotLoggedIn()
        {
            Console.Clear();
            Console.WriteLine("Session limit reached!\n" +
                "Please login again");
            Prompts.ClearAndContinue();
        }
    }
}
