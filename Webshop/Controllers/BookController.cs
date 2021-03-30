using System.Collections.Generic;
using WebshopAPI;
using WebshopMVC.UtilsMVC;
using WebshopMVC.Views;

namespace WebshopMVC.Controllers
{
    public class BookController
    {
        public static List<List<object>> GetBook()
        {
            var api = new API();
            var book = api.GetBook(2);
            var bookData = BookConverters.BookConverter(book);

            return BookView.BookListReader(bookData);
        }

        public static List<List<object>> GetBooks(string keyword)
        {
            var api = new API();
            var bookList = api.GetBooks(keyword);
            var bookListData = BookConverters.BookConverter(bookList);

            return BookView.BookListReader(bookListData);
        }
    }
}