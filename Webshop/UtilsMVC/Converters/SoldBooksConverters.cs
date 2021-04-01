using System;
using System.Collections.Generic;
using System.Text;
using WebshopAPI.Models;

namespace WebshopMVC.UtilsMVC.Converters
{
    public static class SoldBooksConverters
    {
        public static List<List<object>> SoldBooksConverter(List<SoldBook> soldBooksList)
        {
            List<List<object>> soldBooksListData = new List<List<object>>();
            foreach (var item in soldBooksList)
            {
                soldBooksListData.Add(new List<object> { item.Id, item.Title, item.Author, item.Price, item.CategoryId });
            }
            return soldBooksListData;
        }
    }
}
