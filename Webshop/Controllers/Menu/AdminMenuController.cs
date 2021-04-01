using System;
using WebshopAPI.Models;
using WebshopMVC.ControllersAdmin;
using WebshopMVC.UtilsMVC;

namespace WebshopMVC.Controllers.Menu
{
    internal class AdminMenuController
    {
        public static bool isAdminMenuRunning = true;

        public static void AdminMainMenu(User admin)
        {
            isAdminMenuRunning = true;
            while (isAdminMenuRunning)
            {
                Console.Clear();
                ASCII.AdminMainMenuASCII();
                Console.WriteLine("[1] Handle books");
                Console.WriteLine("[2] Handle categories");
                Console.WriteLine("[3] Handle users");
                Console.WriteLine("[4] Go back to main menu");
                Console.WriteLine("[5] Quit application");

                int.TryParse(Console.ReadLine(), out var AdminMainMenuInput);

                switch (AdminMainMenuInput)
                {
                    case 1:
                        AdminBookMenu(admin);
                        break;

                    case 2:
                        AdminCategoryMenu(admin);
                        break;

                    case 3:
                        AdminUserMenu(admin);
                        break;

                    case 4:
                        isAdminMenuRunning = false;
                        break;

                    case 5:
                        isAdminMenuRunning = false;
                        MainMenuController.isMainMenuRunning = false;
                        break;
                }
            }
        }

        public static void AdminBookMenu(User admin)
        {
            bool isAdminBookMenuRunning = true;

            while (isAdminBookMenuRunning)
            {
                Console.Clear();
                ASCII.AdminBookMenuASCII();
                Console.WriteLine("[1] Add a book to inventory");
                Console.WriteLine("[2] Set a book's amount");
                Console.WriteLine("[3] Update a book");
                Console.WriteLine("[4] Delete a book");
                Console.WriteLine("[5] List all sold books");
                Console.WriteLine("[6] Calculate sum of sold books");
                Console.WriteLine("[7] Go back to admin main menu");
                Console.WriteLine("[8] Go back to main menu");
                Console.WriteLine("[9] Quit application");

                int.TryParse(Console.ReadLine(), out var AdminBookMenuInput);

                switch (AdminBookMenuInput)
                {
                    case 1:
                        AdminBookController.AddBookToInventory(admin);
                        break;

                    case 2:
                        AdminBookController.
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        isAdminBookMenuRunning = false;
                        break;

                    case 8:
                        isAdminBookMenuRunning = false;
                        isAdminMenuRunning = false;
                        break;

                    case 9:
                        isAdminBookMenuRunning = false;
                        isAdminMenuRunning = false;
                        MainMenuController.isMainMenuRunning = false;
                        break;
                }
            }
        }

        public static void AdminCategoryMenu(User admin)
        {
            Console.Clear();
            ASCII.AdminCategoryMenuASCII();
            Console.WriteLine("[1] Handle books");
            Console.WriteLine("[2] Handle categories");
            Console.WriteLine("[3] Handle users");
            Console.WriteLine("[4] Go back to main menu");
            Console.WriteLine("[5] Quit application");

            int.TryParse(Console.ReadLine(), out var AdminMenuInput);

            switch (AdminMenuInput)
            {
            }
        }

        public static void AdminUserMenu(User admin)
        {
            Console.Clear();
            ASCII.AdminUserMenuASCII();
            Console.WriteLine("[1] Handle books");
            Console.WriteLine("[2] Handle categories");
            Console.WriteLine("[3] Handle users");
            Console.WriteLine("[4] Go back to main menu");
            Console.WriteLine("[5] Quit application");

            int.TryParse(Console.ReadLine(), out var AdminMenuInput);

            switch (AdminMenuInput)
            {
            }
        }
    }
}