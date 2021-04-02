using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopMVC.Views.Messages;

namespace WebshopMVC.Views
{
    class UserView
    {
        public static List<List<object>> UserListReader(List<List<object>> userData)
        {
            if (userData.Count > 0)
            {
            Console.Clear();
            ConsoleTableBuilder.From(userData).WithTitle("Users", ConsoleColor.Yellow, ConsoleColor.Black)
                .WithColumn("Id   ", "Name   ", "Password   ", "Last login   ", "Sessiontimer   ", "Is active   ","Is admin   ").WithFormat(ConsoleTableBuilderFormat.Minimal).ExportAndWriteLine();
            Prompts.ClearAndContinue();

            }
            return userData;
        }
    }
}
