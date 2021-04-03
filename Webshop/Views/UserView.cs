using ConsoleTableExt;
using System;
using System.Collections.Generic;
using WebshopMVC.Views.Messages;

namespace WebshopMVC.Views
{
    /// <summary>
    /// View class for creating and printing table of User objects
    /// </summary>
    internal class UserView
    {
        /// <summary>
        /// Creates and prints User object table
        /// </summary>
        /// <param name="userData"></param>
        /// <returns>List of List of base class objects</returns>
        public static List<List<object>> UserListReader(List<List<object>> userData)
        {
            if (userData.Count > 0)
            {
                Console.Clear();
                ConsoleTableBuilder.From(userData).WithTitle("Users", ConsoleColor.Yellow, ConsoleColor.Black)
                    .WithColumn("Id   ", "Name   ", "Password   ", "Last login   ", "Sessiontimer   ", "Is active   ", "Is admin   ").WithFormat(ConsoleTableBuilderFormat.Minimal).ExportAndWriteLine();
                Prompts.ClearAndContinue();
            }
            return userData;
        }
    }
}