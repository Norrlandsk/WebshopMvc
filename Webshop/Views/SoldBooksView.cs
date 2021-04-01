using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopMVC.Views.Messages;

namespace WebshopMVC.Views
{
    class SoldBooksView
    {
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
