using System.Collections.Generic;
using WebshopAPI.Models;

namespace WebshopMVC.UtilsMVC.Converters
{
    internal class CategoryConverters
    {
        public static List<List<object>> CategoryConverter(List<BookCategory> categoryList)
        {
            List<List<object>> categoryListData = new List<List<object>>();
            foreach (var item in categoryList)
            {
                categoryListData.Add(new List<object> { item.Id, item.Name });
            }
            return categoryListData;
        }
    }
}