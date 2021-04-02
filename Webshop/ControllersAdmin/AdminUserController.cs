using System;
using System.Collections.Generic;
using WebshopAPI;
using WebshopAPI.Models;
using WebshopAPI.Utils;
using WebshopMVC.Controllers;
using WebshopMVC.UtilsMVC.Converters;
using WebshopMVC.Views;
using WebshopMVC.Views.Messages.Admin;
using WebshopMVC.Views.Messages.Admin.UserMessages;

namespace WebshopMVC.ControllersAdmin
{
    public static class AdminUserController
    {
        public static List<List<object>> ListAllUsers(User admin)
        {
            List<List<object>> userListData = new List<List<object>>();
            bool isUsersListed = false;
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

                var result = api.ListUsers(admin.Id);
                if (result == null)
                {
                    ListAllUsersMessage.Error();
                    break;
                }
                else
                {
                    userListData = UserConverters.UserConverter(result);

                    UserController.SendPing(admin.Id);
                    isUsersListed = true;
                }
            } while (isUsersListed == false);
            return UserView.UserListReader(userListData);
        }

        public static List<List<object>> FindUser(User admin)
        {
            List<List<object>> userListData = new List<List<object>>();
            bool isUsersFound = false;
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
                Console.Write("Enter search term: ");
                var keyword = Console.ReadLine();
                var result = api.FindUser(admin.Id, keyword);
                if (result.Count <1)
                {
                    var input = FindUserMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    userListData = UserConverters.UserConverter(result);

                    UserController.SendPing(admin.Id);
                    isUsersFound = true;
                }
            } while (isUsersFound == false);
            return UserView.UserListReader(userListData);
        }
    }
}