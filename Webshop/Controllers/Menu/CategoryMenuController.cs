using System;
using WebshopMVC.UtilsMVC;

namespace WebshopMVC.Controllers.Menu
{
    internal class CategoryMenuController
    {
        public static void CategoryMenu()
        {
            bool isCategoryMenuRunning = true;
            while (isCategoryMenuRunning)
            {
                Console.Clear();
                ASCII.CategoryMenuASCII();
                Console.WriteLine("[1] List all categories");
                Console.WriteLine("[2] Search for categories");
                Console.WriteLine("[3] List all books in category");
                Console.WriteLine("[4] List all books in category currently in stock\n");

                Console.WriteLine("[5] Go back to main menu");
                Console.WriteLine("[6] Quit application");

                int.TryParse(Console.ReadLine(), out var categoryMenuInput);

                switch (categoryMenuInput)
                {
                    case 1:
                        CategoryController.ListAllCategories();
                        break;

                    case 2:
                        
                        break;

                    case 3:
                       
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        isCategoryMenuRunning = false;

                        break;

                    case 6:
                        isCategoryMenuRunning = false;
                        MainMenuController.isMainMenuRunning = false;
                        break;
                }
            }
        }
    }
}