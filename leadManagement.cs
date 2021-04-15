using System;
using System.Collections.Generic;
using System.Text;

namespace ClientManagementSystem
{
    class leadManagement
    {
       public void leadTab() {

            Console.WriteLine("To Create a lead. Please Type C");
            string userChoice = Console.ReadLine();

            
            if (userChoice.Equals("C", StringComparison.OrdinalIgnoreCase))
            {
               
                Console.WriteLine("Create Lead\n\n");

                Console.WriteLine("Lead Information\n");

                Console.WriteLine("Company Name: ");
                    string companyName = Console.ReadLine();

                Console.WriteLine("First Name:");
                    string firstName = Console.ReadLine();

                Console.WriteLine("Last Name:");
                    string lastName = Console.ReadLine();

                Console.WriteLine("Title Or Position:");
                    string titleOrPosition = Console.ReadLine();

                Console.WriteLine("E-mail Address:");
                    string emailAdd = Console.ReadLine();

                Console.WriteLine("Phone Number");
                    int phoneNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Mobile Number");
                    string mobileNum = Console.ReadLine();

                Console.WriteLine("Website Link:");
                    string websiteLink = Console.ReadLine();

                Console.WriteLine("Lead Source:");
                    string leadSource = Console.ReadLine();

                Console.WriteLine("Lead Status");
                    string leadStatus = Console.ReadLine();

                Console.WriteLine("Industry:");
                    string Industry = Console.ReadLine();

                Console.WriteLine("Number Of Employees:");
                    int numOfEmployees = int.Parse(Console.ReadLine());

                Console.WriteLine("Annual Revenue:");
                    int annualRevenue = int.Parse(Console.ReadLine());

                Console.WriteLine("Rating:");
                    string rating = Console.ReadLine();

                Console.WriteLine("Skype Id:");
                string skypeId = Console.ReadLine();


                Console.WriteLine("Company Name: " + companyName);
                Console.WriteLine("First Name: " + firstName);
                Console.WriteLine("Last Name: " + lastName);
                Console.WriteLine("Title or Position: " + titleOrPosition);
                Console.WriteLine("E-mail Address: " + emailAdd);
                Console.WriteLine("Phone Number: " + phoneNum);
                Console.WriteLine("Mobile Number:" + mobileNum);
                Console.WriteLine("Website Link: " + websiteLink);
                Console.WriteLine("Lead Source: " + leadSource);
                Console.WriteLine("Lead Status: " + leadStatus);
                Console.WriteLine("Industry: " + Industry);
                Console.WriteLine("Number of Employees: " + numOfEmployees);
                Console.WriteLine("Annual Revenue: " + annualRevenue);
                Console.WriteLine("Rating: " + rating);
                Console.WriteLine("Skype ID: " + skypeId);

            }
            else {
                Console.WriteLine("Please try again!");
            }

            
        
        }
    }
}
