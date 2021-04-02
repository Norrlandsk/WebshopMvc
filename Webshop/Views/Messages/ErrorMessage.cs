using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages
{
    class ErrorMessage
    {
        public static string ErrorAbort(string input1="",string input2="")
        {
            Console.Clear();
            Console.WriteLine($"Something went wrong when {input1}! Either your session timed out and you have to log in again, \n" +
                $"or {input2}");
            return Prompts.Abort();
        }

        public static void ErrorNoAbort(string input1 = "", string input2 = "")
        {
            Console.Clear();
            Console.WriteLine($"Something went wrong when {input1}! Either your session timed out and you have to log in again, \n" +
                $"or {input2}");
            Prompts.ClearAndContinue();

        }
    }
}
