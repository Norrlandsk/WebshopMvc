using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Text;
using WebshopMVC.Views.Messages;

namespace WebshopMVC.Views
{
    class CategoryView
    {
        public static List<List<object>> CategoryListReader(List<List<object>> categoryData)
        {
            Console.Clear();
            ConsoleTableBuilder.From(categoryData).WithTitle("Categories", ConsoleColor.Yellow, ConsoleColor.Black)
                .WithColumn("Id   ","Name   ").WithFormat(ConsoleTableBuilderFormat.Minimal).ExportAndWriteLine();
            Prompts.ClearAndContinue();
            return categoryData;
        }
    }
}
