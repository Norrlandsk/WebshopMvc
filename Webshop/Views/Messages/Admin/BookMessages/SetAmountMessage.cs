using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin
{
    public static class SetAmountMessage
    {
        public static string Error()
        {
            Console.Clear();
            Console.WriteLine("Something went when setting the amount! Either your session timed out and you have to log in again, \n" +
                "or you entered incorrect data");
            return Prompts.Abort();
        }
        public static void Success(int amount)
        {
            Console.Clear();
            Console.WriteLine($"Amount set to {amount}!");
            Prompts.ClearAndContinue();
        }
    }
}
