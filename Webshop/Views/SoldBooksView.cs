using ConsoleTableExt;
using System;
using System.Collections.Generic;
using WebshopMVC.Views.Messages;

namespace WebshopMVC.Views
{
    /// <summary>
    /// View class for creating and printing table of SoldBook objects
    /// </summary>
    internal class SoldBooksView
    {
        /// <summary>
        /// Creates and prints SoldBook object table
        /// </summary>
        /// <param name="soldBooksData"></param>
        /// <returns>List of List of base class objects</returns>
        public static List<List<object>> SoldBooksListReader(List<List<object>> soldBooksData)
        {
            Console.Clear();
            ConsoleTableBuilder.From(soldBooksData).WithTitle("Sold books", ConsoleColor.Yellow, ConsoleColor.Black)
                .WithColumn("Id   ", "Title   ", "Author   ", "Price   ", "Category Id   ").WithFormat(ConsoleTableBuilderFormat.Minimal).ExportAndWriteLine();
            Prompts.ClearAndContinue();
            return soldBooksData;
        }
    }
}