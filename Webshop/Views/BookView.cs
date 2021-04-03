using ConsoleTableExt;
using System;
using System.Collections.Generic;
using WebshopMVC.Views.Messages;

namespace WebshopMVC.Views
{
    /// <summary>
    /// View class for creating and printing table of Book objects
    /// </summary>
    internal class BookView
    {
        /// <summary>
        /// Creates and prints Book object table
        /// </summary>
        /// <param name="bookData"></param>
        /// <returns>List of List of base class objects</returns>
        public static List<List<object>> BookListReader(List<List<object>> bookData)
        {
            Console.Clear();
            ConsoleTableBuilder.From(bookData).WithTitle("Books", ConsoleColor.Yellow, ConsoleColor.Black)
                .WithColumn("Id   ", "Title   ", "Author   ", "Price   ", "Amount   ", "Category Id   ").WithFormat(ConsoleTableBuilderFormat.Minimal).ExportAndWriteLine();
            Prompts.ClearAndContinue();
            return bookData;
        }
    }
}