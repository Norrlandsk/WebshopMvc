using System;
using System.Collections.Generic;
using WebshopAPI;
using WebshopMVC.UtilsMVC;
using WebshopMVC.Views;

namespace WebshopMVC.Controllers
{
    public class BookController
    {
        public static List<List<object>> GetBookById()
        {
            Console.Clear();
            var api = new API();
            Console.Write("Enter book Id:");
            int.TryParse(Console.ReadLine(), out var input);
            var book = api.GetBook(input);
            var bookData = BookConverters.BookConverter(book);

            return BookView.BookListReader(bookData);
        }

        public static List<List<object>> GetBooksByKeyword()
        {
            Console.Clear();
            var api = new API();
            Console.Write("Enter search term:");
            var keyword = Console.ReadLine();
            var bookList = api.GetBooks(keyword);
            var bookListData = BookConverters.BookConverter(bookList);

            return BookView.BookListReader(bookListData);
        }

        public static List<List<object>> ListAllBooks()
        {
            Console.Clear();
            var api = new API();
            var bookList = api.GetAllBooks();
            var bookListData = BookConverters.BookConverter(bookList);

            return BookView.BookListReader(bookListData);
        }

        public static List<List<object>> GetBooksByAuthor()
        {
            Console.Clear();
            var api = new API();
            Console.Write("Enter search term:");
            var keyword = Console.ReadLine();
            var bookList = api.GetAuthors(keyword);
            var bookListData = BookConverters.BookConverter(bookList);

            return BookView.BookListReader(bookListData);
        }
    }
}