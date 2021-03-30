using System;
using System.Collections.Generic;
using System.Text;
using WebshopMVC.UtilsMVC;

namespace WebshopMVC.Controllers.Menu
{
    class BookMenuController
    {
        public static void BookMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
            ASCII.BookMenuASCII();
            Console.WriteLine("[1] List all books");
            Console.WriteLine("[2] Search books by title");
            Console.WriteLine("[3] Search books by author");
            Console.WriteLine("[4] Get book information by Id\n");
            Console.WriteLine("[5] List all categories");
            Console.WriteLine("[6] Search for categories");
            Console.WriteLine("[7] List all books in category");
            Console.WriteLine("[8] List all books in category currently in stock\n\n");

            }
        }
    }
}
