using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    WELCOME TO THE RECIPE SYSTEM");

            Console.Write("\r\nEnter your Reference Code to access: ");

            string userinput = Console.ReadLine();

            if (Account.Login(userinput))
            {
                Menu.Show(userinput);
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}

