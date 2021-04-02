using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages
{
    class Prompts
    {
        public static void ClearAndContinue()
        {
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static string Abort()
        {
            Console.WriteLine("\nPress enter to try again or x to abort...");
            var input=Console.ReadLine();
            return input;
        }
    }
}
