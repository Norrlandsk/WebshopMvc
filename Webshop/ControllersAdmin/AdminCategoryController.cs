using System;
using WebshopAPI;
using WebshopAPI.Models;
using WebshopAPI.Utils;
using WebshopMVC.Controllers;
using WebshopMVC.Views.Messages.Admin;
using WebshopMVC.Views.Messages.Admin.CategoryMessages;

namespace WebshopMVC.ControllersAdmin
{
    internal class AdminCategoryController
    {
        public static void AddCategory(User admin)
        {
            bool isCategoryCreated = false;
            do
            {
                if (SessionTimer.CheckSessionTimer(admin.SessionTimer) == true || admin.SessionTimer == DateTime.MinValue)
                {
                    Console.Clear();
                    GeneralMessage.AdminNotLoggedIn();
                    break;
                }

                Console.Clear();
                var api = new API();

                Console.Write("Enter name:");
                var categoryName = Console.ReadLine();

                var result = api.AddCategory(admin.Id, categoryName);
                if (result == false)
                {
                    var input = AddCategoryMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    AddCategoryMessage.Success();
                    isCategoryCreated = true;
                    UserController.SendPing(admin.Id);
                }
            } while (isCategoryCreated == false);
        }

        public static void AddBookToCategory(User admin)
        {
            bool isBookAdded = false;
            do
            {
                if (SessionTimer.CheckSessionTimer(admin.SessionTimer) == true || admin.SessionTimer == DateTime.MinValue)
                {
                    Console.Clear();
                    GeneralMessage.AdminNotLoggedIn();
                    break;
                }

                Console.Clear();
                var api = new API();

                Console.Write("Enter book Id:");
                int.TryParse(Console.ReadLine(), out int bookId);

                Console.Write("Enter category Id:");
                int.TryParse(Console.ReadLine(), out int categoryId);

                var result = api.AddBookToCategory(admin.Id, bookId, categoryId);
                if (result == false)
                {
                    var input = AddBookToCategoryMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    AddBookToCategoryMessage.Success();
                    isBookAdded = true;
                    UserController.SendPing(admin.Id);
                }
            } while (isBookAdded == false);
        }

        public static void UpdateCategory(User admin)
        {
            bool isCategoryUpdated = false;
            do
            {
                if (SessionTimer.CheckSessionTimer(admin.SessionTimer) == true || admin.SessionTimer == DateTime.MinValue)
                {
                    Console.Clear();
                    GeneralMessage.AdminNotLoggedIn();
                    break;
                }

                Console.Clear();
                var api = new API();

                Console.Write("Enter category Id:");
                int.TryParse(Console.ReadLine(), out int categoryId);

                Console.Write("Enter new name:");
                var name = Console.ReadLine();

                var result = api.UpdateCategory(admin.Id, categoryId, name);
                if (result == false)
                {
                    var input = UpdateCategoryMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    UpdateCategoryMessage.Success();
                    isCategoryUpdated = true;
                    UserController.SendPing(admin.Id);
                }
            } while (isCategoryUpdated == false);
        }
        public static void DeleteCategory(User admin)
        {
            bool isCategoryDeleted = false;
            do
            {
                if (SessionTimer.CheckSessionTimer(admin.SessionTimer) == true || admin.SessionTimer == DateTime.MinValue)
                {
                    Console.Clear();
                    GeneralMessage.AdminNotLoggedIn();
                    break;
                }

                Console.Clear();
                var api = new API();

                Console.Write("Enter category Id:");
                int.TryParse(Console.ReadLine(), out int categoryId);

                var result = api.DeleteCategory(admin.Id, categoryId);
                if (result == false)
                {
                    var input = DeleteCategoryMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    DeleteCategoryMessage.Success();
                    isCategoryDeleted = true;
                    UserController.SendPing(admin.Id);
                }
            } while (isCategoryDeleted == false);
        }
    }
}