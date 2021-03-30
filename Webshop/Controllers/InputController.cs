using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace WebshopMVC.Controllers
{
    class InputController
    {
        public static void UserInput(params Tuple<string,string>[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine($"Enter {item.Item1}");
               // item.Item2 = Console.ReadLine();
            }
        }
    }
}
