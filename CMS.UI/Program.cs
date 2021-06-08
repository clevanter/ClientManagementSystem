using System;
using System.Collections.Generic;
using CMS.BL;


namespace CMS.UI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            UserManagement ToLogin = new UserManagement();
            Choices choices = new Choices();
            Console.WriteLine("Verimk: Your #1 Client Management Software\n");
            Console.WriteLine("Please LOG-IN\n");
            ToLogin.username = "Clevanter325";
            ToLogin.password = "12345678";
            ToLogin.Admin();
            choices.DisplayAction();
            choices.TheChoice();
               
        }
    }
}





