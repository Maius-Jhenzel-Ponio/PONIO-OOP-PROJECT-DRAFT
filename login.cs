using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    internal static class Account
    {
        static List<string> Users = new List<string>();

        static void CreateDummyCodes()
        {
            Users.Add("COOK");
            Users.Add("RECIPE");
            Users.Add("CUISINE");
            Users.Add("FILIPINO");
            Users.Add("DELICIOUS");

        }

        public static bool Login(string usernumber)
        {
            CreateDummyCodes();

            bool result = false;

            foreach (var user in Users)
            {
                if (user == usernumber)
                {
                    result = true;
                }
            }
            return result;
        }

    }
}