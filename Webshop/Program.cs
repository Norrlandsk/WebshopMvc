using WebshopAPI;
using WebshopMVC.Controllers;

namespace Webshop
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Startup.InitialiseDatabase();
            Startup.InitialiseSeed();
            MainMenuController.MainMenu(Startup.sessionCookie);
        }
    }
}