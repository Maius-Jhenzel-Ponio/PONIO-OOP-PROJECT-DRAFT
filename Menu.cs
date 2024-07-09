using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    internal static class Menu
    {

        static List<string> RecipeMenu = new List<string>();
        private static void CreateMenus()
        {
            RecipeMenu.Add("Pork Sinigang");
            RecipeMenu.Add("Chicken Adobo");
            RecipeMenu.Add("Pork Adobo");
            RecipeMenu.Add("Kare-Kare");
            RecipeMenu.Add("Menudo");

            RecipeMenu.Add("Logout");

        }

        public static void Show(string user)
        {
            CreateMenus();

            string usertype = "";

            Console.WriteLine("\r\nSelect dishes you want to cook below:");

            {
                usertype = "select";
                for (int i = 0; i < RecipeMenu.Count; i++)
                {
                    Console.WriteLine($"Enter {i + 1} to {RecipeMenu[i]}");
                }
            }

            Console.Write("\r\nInput number to select: ");

            int selectedMenu = Convert.ToInt32(Console.ReadLine());

            ProcessSelectedMenu(selectedMenu, usertype);
        }

        private static void ProcessSelectedMenu(int menu, string usertype)
        {
            if (usertype == "select")
            {
                switch (menu)
                {
                    case 1:
                        User.PorkSinigang();
                        break;
                    case 2:
                        User.ChickenAdobo();
                        break;
                    case 3:
                        User.PorkAdobo();
                        break;
                    case 4:
                        User.Karekare();
                        break;
                    case 5:
                        User.PorkMenudo();
                        break;
                    case 6:
                        User.Logout();
                        break;
                    default:
                        Console.WriteLine("Menu not existing...");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Invalid user type.");
            }
        }
    }
}
