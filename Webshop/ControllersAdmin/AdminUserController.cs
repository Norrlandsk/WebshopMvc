﻿using System;
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
                if (result.Count < 1)
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

        public static void AddUser(User admin)
        {
            bool isUserCreated = false;
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
                Console.Write("Enter name: ");
                var name = Console.ReadLine();

                Console.Write("Enter password: ");
                var password = Console.ReadLine();

                var result = api.AddUser(admin.Id, name, password);
                if (result == false)
                {
                    var input = AddUserMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    AddUserMessage.Success();

                    UserController.SendPing(admin.Id);
                    isUserCreated = true;
                }
            } while (isUserCreated == false);
        }

        public static List<List<object>> BestCostumer(User admin)
        {
            List<List<object>> bestCostumer = new List<List<object>>();
            bool isCostumerListed = false;
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

                var result = api.BestCostumer(admin.Id);
                if (result == null)
                {
                    BestCostumerMessage.Error();
                    break;
                }
                else
                {
                    bestCostumer = UserConverters.UserConverter(result);
                    UserController.SendPing(admin.Id);
                    isCostumerListed = true;
                }
            } while (isCostumerListed == false);
            return UserView.UserListReader(bestCostumer);
        }

        public static void PromoteUser(User admin)
        {
            bool isUserPromoted = false;
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
                Console.Write("Enter user Id: ");
                int.TryParse(Console.ReadLine(), out int userId);
                var result = api.Promote(admin.Id, userId);
                if (result == false)
                {
                    var input = PromoteUserMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    PromoteUserMessage.Success();

                    UserController.SendPing(admin.Id);
                    isUserPromoted = true;
                }
            } while (isUserPromoted == false);
        }

        public static void DemoteUser(User admin)
        {
            bool isUserDemoted = false;
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
                Console.Write("Enter user Id: ");
                int.TryParse(Console.ReadLine(), out int userId);
                var result = api.Demote(admin.Id, userId);
                if (result == false)
                {
                    var input = DemoteUserMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    DemoteUserMessage.Success();

                    UserController.SendPing(admin.Id);
                    isUserDemoted = true;
                }
            } while (isUserDemoted == false);
        }

        public static void ActivateUser(User admin)
        {
            bool isUserActivated = false;
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
                Console.Write("Enter user Id: ");
                int.TryParse(Console.ReadLine(), out int userId);
                var result = api.ActivateUser(admin.Id, userId);
                if (result == false)
                {
                    var input = DemoteUserMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    DemoteUserMessage.Success();

                    UserController.SendPing(admin.Id);
                    isUserActivated = true;
                }
            } while (isUserActivated == false);
        }

        public static void DeactivateUser(User admin)
        {
            bool isUserDeactivated = false;
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
                Console.Write("Enter user Id: ");
                int.TryParse(Console.ReadLine(), out int userId);
                var result = api.InactivateUser(admin.Id, userId);
                if (result == false)
                {
                    var input = DeactivateUserMessage.Error();
                    if (input != "")
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    DeactivateUserMessage.Success();

                    UserController.SendPing(admin.Id);
                    isUserDeactivated = true;
                }
            } while (isUserDeactivated == false);
        }
    }
}