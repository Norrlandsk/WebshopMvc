using ConsoleTableExt;
using System;
using System.Collections.Generic;
using WebshopMVC.Views.Messages;

namespace WebshopMVC.Views
{
    /// <summary>
    /// View class for creating and printing table of Category objects
    /// </summary>
    internal class CategoryView
    {
        /// <summary>
        /// Creates and prints Category object table
        /// </summary>
        /// <param name="categoryData"></param>
        /// <returns>List of List of base class objects</returns>
        public static List<List<object>> CategoryListReader(List<List<object>> categoryData)
        {
            Console.Clear();
            ConsoleTableBuilder.From(categoryData).WithTitle("Categories", ConsoleColor.Yellow, ConsoleColor.Black)
                .WithColumn("Id   ", "Name   ").WithFormat(ConsoleTableBuilderFormat.Minimal).ExportAndWriteLine();
            Prompts.ClearAndContinue();
            return categoryData;
        }
    }
}