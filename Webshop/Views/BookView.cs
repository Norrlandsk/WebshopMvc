using ConsoleTableExt;
using System;
using System.Collections.Generic;
using WebshopMVC.Views.Messages;

namespace WebshopMVC.Views
{
    internal class BookView
    {
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