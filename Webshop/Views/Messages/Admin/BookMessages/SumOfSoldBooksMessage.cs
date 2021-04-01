using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages.Admin
{
    class SumOfSoldBooksMessage
    {
        public static void Error()
        {
            Console.Clear();
            Console.WriteLine("Something went when calculating! Either your session timed out and you have to log in again, \n" +
                "or the database is empty or corrupted");
            Prompts.ClearAndContinue();
        }

        public static void Success(int? sum)
        {
            Console.Clear();
            Console.WriteLine($"The sum of all sold books is {sum}!");
            Prompts.ClearAndContinue();
        }
    }
}
