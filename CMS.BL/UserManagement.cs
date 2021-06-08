using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class UserManagement
    {
        public string username { get; set; }
        public string password { get; set; }

        public void Admin()
        {
            Console.Write("Username: \n");
            string getusername = Console.ReadLine();
            Console.WriteLine("Password: ");
            string getpassword = Console.ReadLine();

            if (username==getusername && password==getpassword)
            {
                Console.WriteLine("Successfully Log-in!");
            }
            else 
            {
                Console.WriteLine("Incorrect Credentials\n");
                Admin();
            }
        }
    }
}

