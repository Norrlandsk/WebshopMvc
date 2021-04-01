using System;
using System.Collections.Generic;
using System.Text;
using WebshopAPI;
using WebshopMVC.UtilsMVC;
using WebshopMVC.UtilsMVC.Converters;
using WebshopMVC.Views;

namespace WebshopMVC.Controllers
{
    public static class CategoryController
    {
        public static List<List<object>> ListAllCategories()
        {
            Console.Clear();
            var api = new API();
            var categoryList = api.GetCategories();
            var categoryListData = CategoryConverters.CategoryConverter(categoryList);

            return CategoryView.CategoryListReader(categoryListData);
        }

        public static List<List<object>> GetCategoriesByKeyword()
        {
            Console.Clear();
            var api = new API();
            Console.Write("Enter search term:");
            var keyword=Console.ReadLine();
            var categoryList = api.GetCategories(keyword);
            var categoryListData = CategoryConverters.CategoryConverter(categoryList);

            return CategoryView.CategoryListReader(categoryListData);
        }

        public static List<List<object>> GetBooksByCategoryId()
        {
            Console.Clear();
            var api = new API();
            Console.Write("Enter category Id:");
            int.TryParse(Console.ReadLine(), out int categoryId);
            var bookList = api.GetCategory(categoryId);
            var categoryListData = BookConverters.BookConverter(bookList);

            return BookView.BookListReader(categoryListData);
        }

        public static List<List<object>> GetAvailableBooksByCategoryId()
        {
            Console.Clear();
            var api = new API();
            Console.Write("Enter category Id:");
            int.TryParse(Console.ReadLine(), out int categoryId);
            var bookList = api.GetAvailableBooks(categoryId);
            var categoryListData = BookConverters.BookConverter(bookList);

            return BookView.BookListReader(categoryListData);
        }
    }
}
