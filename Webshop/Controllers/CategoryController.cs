using System;
using System.Collections.Generic;
using System.Text;
using WebshopAPI;
using WebshopMVC.UtilsMVC.Converters;
using WebshopMVC.Views;

namespace WebshopMVC.Controllers
{
    class CategoryController
    {
        public static List<List<object>> ListAllCategories()
        {
            Console.Clear();
            var api = new API();
            var categoryList = api.GetCategories();
            var categoryListData = CategoryConverters.CategoryConverter(categoryList);

            return CategoryView.CategoryListReader(categoryListData);
        }
    }
}
