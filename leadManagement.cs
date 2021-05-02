using System;

namespace ClientManagementSystem
{
    class LeadManagement
    {
        public void LeadTab()
        {

            Console.WriteLine("To Create a lead. Please type 'C'. To exit type 'E'");
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
                string numOfEmployees = Console.ReadLine();

                Console.WriteLine("Annual Revenue:");
                string annualRevenue = Console.ReadLine();

                Console.WriteLine("Rating:");
                string rating = Console.ReadLine();

                Console.WriteLine("Skype Id:");
                string skypeId = Console.ReadLine();

                Console.WriteLine("Company Name: " + companyName);
                Console.WriteLine("\nFirst Name: " + firstName);
                Console.WriteLine("\nLast Name: " + lastName);
                Console.WriteLine("\nTitle or Position: " + titleOrPosition);
                Console.WriteLine("\nE-mail Address: " + emailAdd);
                Console.WriteLine("\nPhone Number: " + phoneNum);
                Console.WriteLine("\nMobile Number:" + mobileNum);
                Console.WriteLine("\nWebsite Link: " + websiteLink);
                Console.WriteLine("\nLead Source: " + leadSource);
                Console.WriteLine("\nLead Status: " + leadStatus);
                Console.WriteLine("\nIndustry: " + Industry);
                Console.WriteLine("\nNumber of Employees: " + numOfEmployees);
                Console.WriteLine("\nAnnual Revenue: " + annualRevenue);
                Console.WriteLine("\nRating: " + rating);
                Console.WriteLine("\nSkype ID: " + skypeId);
            }

            else
            { 
                Console.WriteLine("Program is Exiting.");
            }


        }
   

    }


}


    


