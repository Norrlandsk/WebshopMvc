using System;
using System.Collections.Generic;
using System.Text;
using WebshopAPI;
using WebshopAPI.Models;
using WebshopAPI.Utils;
using WebshopMVC.Controllers;
using WebshopMVC.UtilsMVC;
using WebshopMVC.Views;
using WebshopMVC.Views.Messages;
using WebshopMVC.Views.Messages.Admin;

namespace WebshopMVC.ControllersAdmin
{
    class AdminBookController
    {
        public static void AddBookToInventory(User admin)
        {
            bool isBookAdded = false;
            do
            {
                if (SessionTimer.CheckSessionTimer(admin.SessionTimer) == true || admin.SessionTimer == DateTime.MinValue)
                {
                    Console.Clear();
                    AddBookMessage.AdminNotLoggedIn();
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
                    isBookAdded=true;
                    UserController.SendPing(admin.Id);
                }
            } while (isBookAdded == false);

        }
        public static void SetAmount(User admin)
        {
            bool isBookAdded = false;
            do
            {
                if (SessionTimer.CheckSessionTimer(admin.SessionTimer) == true || admin.SessionTimer == DateTime.MinValue)
                {
                    Console.Clear();
                    AddBookMessage.AdminNotLoggedIn();
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
    }
}
