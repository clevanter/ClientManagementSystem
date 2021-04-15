using System;

namespace ClientManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verimk: your number #1 client management software!\n");
            Console.Write("Home ");
            Console.Write("Inbox ");
            Console.Write("Leads ");
            Console.Write("Contacts ");
            Console.Write("Accounts ");
            Console.Write("Task ");
            Console.WriteLine("Reports\n");


            leadManagement Leads = new leadManagement();

            Console.WriteLine("Please choose the tab you want to view according to its first letter. Just type a letter then your good to go!");
            string userChoice = Console.ReadLine();


            if (userChoice.Equals("H", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Home: Ongoing :)"); // will consist of feed, summary of contacts & interaction tracking, calendar
            }
            else if (userChoice.Equals("I", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Inbox: Ongoing :)"); // will consist of conversation
            }
            else if (userChoice.Equals("L",StringComparison.OrdinalIgnoreCase))
            {
                Leads.leadTab();
                Console.WriteLine(Leads); // another class // consist of leads (prospects that you are contacting to see if there will be an opportunity to provide them your goods or services.)
            }
            else if (userChoice.Equals("C", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Contacts: Ongoing :)"); // will consist of contacts (person(s) with whom a communication is established to pursue a relationship or a business opportunity.)
            }
            else if (userChoice.Equals("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Accounts: Ongoing"); // will consist business to business relationships.
            }
            else if (userChoice.Equals("T", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Task: Ongoing"); // will consist a task list or to-do list.
            }
            else if (userChoice.Equals("R", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Reports: Ongoing"); // will consist of reports (sales and etc)
            }
            else
            {
                Console.WriteLine("Please try again!");



            }
        }
    }
}
