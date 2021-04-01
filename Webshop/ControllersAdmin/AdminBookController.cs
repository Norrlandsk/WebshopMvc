using System;
using System.Collections.Generic;
using WebshopAPI;
using WebshopAPI.Models;
using WebshopAPI.Utils;
using WebshopMVC.Controllers;
using WebshopMVC.UtilsMVC.Converters;
using WebshopMVC.Views;
using WebshopMVC.Views.Messages.Admin;

namespace WebshopMVC.ControllersAdmin
{
    internal class AdminBookController
    {
        public static void AddBookToInventory(User admin)
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
                Console.Write("Enter title:");
                var title = Console.ReadLine();

                Console.Write("Enter author:");
                var author = Console.ReadLine();

                Console.Write("Enter price:");
                int.TryParse(Console.ReadLine(), out var price);

                Console.Write("Enter amount:");
                int.TryParse(Console.ReadLine(), out var amount);

                var result = api.AddBook(admin.Id, title, author, price, amount);
                if (result == false)
                {
                    var input = AddBookMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    AddBookMessage.Success();
                    isBookAdded = true;
                    UserController.SendPing(admin.Id);
                }
            } while (isBookAdded == false);
        }

        public static void SetAmount(User admin)
        {
            bool isAmountSet = false;
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
                int.TryParse(Console.ReadLine(), out var bookId);

                Console.Write("Enter amount:");
                int.TryParse(Console.ReadLine(), out var amount);

                var result = api.SetAmount(admin.Id, bookId, amount);
                if (result.isAmountSet == false)
                {
                    var input = SetAmountMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    SetAmountMessage.Success(result.amount);
                    isAmountSet = true;
                    UserController.SendPing(admin.Id);
                }
            } while (isAmountSet == false);
        }

        public static void UpdateBook(User admin)
        {
            bool isBookUpdated = false;
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
                Console.Write("Enter book Id: ");
                int.TryParse(Console.ReadLine(), out var bookId);

                Console.Write("Enter title: ");
                var title = Console.ReadLine();

                Console.Write("Enter author: ");
                var author = Console.ReadLine();

                Console.Write("Enter price: ");
                int.TryParse(Console.ReadLine(), out var price);

                var result = api.UpdateBook(admin.Id, bookId, title, author, price);
                if (result == false)
                {
                    var input = UpdateBookMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    UpdateBookMessage.Success();
                    isBookUpdated = true;
                    UserController.SendPing(admin.Id);
                }
            } while (isBookUpdated == false);
        }

        public static void DeleteBook(User admin)
        {
            bool isBookDeleted = false;
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
                Console.Write("Enter book Id: ");
                int.TryParse(Console.ReadLine(), out var bookId);

                var result = api.DeleteBook(admin.Id, bookId);
                if (result == false)
                {
                    var input = DeleteBookMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    DeleteBookMessage.Success();
                    isBookDeleted = true;
                    UserController.SendPing(admin.Id);
                }
            } while (isBookDeleted == false);
        }

        public static List<List<object>> ListAllSoldBooks(User admin)
        {
            List<List<object>> soldBooksListData = new List<List<object>>();
            bool isListed = false;
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

                var result = api.SoldItems(admin.Id);
                if (result == null)
                {
                    var input = SoldItemsMessage.Error();
                }
                else
                {
                    soldBooksListData = SoldBooksConverters.SoldBooksConverter(result);
                    UserController.SendPing(admin.Id);
                    isListed = true;
                }
            } while (isListed == false);
            return SoldBooksView.SoldBooksListReader(soldBooksListData);
        }

        public static void SumOfSoldBooks(User admin)
        {

            bool isSumCalculated = false;
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

                var result = api.MoneyEarned(admin.Id);
                if (result == null)
                {
                    SumOfSoldBooksMessage.Error();
                }
                else
                {
                    SumOfSoldBooksMessage.Success(result);
                    UserController.SendPing(admin.Id);
                    isSumCalculated = true;
                }
            } while (isSumCalculated == false);
            
        }
    }
}