using System;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Views.Messages
{
    class SuccessMessage
    {
        public static void SuccessWithInt(string input1,int input2=0)
        {
            Console.Clear();
            Console.WriteLine($"{input1} {input2}!");
            Prompts.ClearAndContinue();
        }
        public static void SuccessWithString(string input1, string input2="")
        {
            Console.Clear();
            Console.WriteLine($"{input1} {input2}!");
            Prompts.ClearAndContinue();
        }

    }
}
