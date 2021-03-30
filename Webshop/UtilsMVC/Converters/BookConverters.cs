using System.Collections.Generic;
using WebshopAPI.Models;
using WebshopMVC.Views;

namespace WebshopMVC.UtilsMVC
{
    internal class BookConverters
    {
        public static List<List<object>> BookConverter(List<Book> bookList)
        {
            List<List<object>> bookListData = new List<List<object>>();
            foreach (var item in bookList)
            {
                bookListData.Add(new List<object> { item.Id, item.Title, item.Author, item.Price, item.Amount, item.CategoryId });
            }
            return bookListData;
        }

        public static List<List<object>> BookConverter(Book book)
        {
            List<List<object>> bookData = new List<List<object>>()
            {new List<object>() { book.Id, book.Title, book.Author, book.Price, book.Amount, book.CategoryId } };

            return bookData;
        }
    }
}