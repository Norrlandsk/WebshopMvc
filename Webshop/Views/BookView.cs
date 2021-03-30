using ConsoleTableExt;
using System;
using System.Collections.Generic;

namespace WebshopMVC.Views
{
    internal class BookView
    {
        public static List<List<object>> BookListReader(List<List<object>> bookData)
        {
            ConsoleTableBuilder.From(bookData).WithTitle("Books", ConsoleColor.Yellow, ConsoleColor.Black)
                .WithColumn("Id   ", "Title   ", "Author   ", "Price   ", "Amount   ", "Category Id   ").WithFormat(ConsoleTableBuilderFormat.Minimal).ExportAndWriteLine();

            return bookData;
        }
    }
}