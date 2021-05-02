using System;
using System.Collections.Generic;

namespace ClientManagementSystem
{
    class Program
    {
        public static List<string> Managements = new List<string>()
                { "'H' to view Home",
                  "'I' to view Inbox",
                  "'L' to view Leads",
                  "'C' to view Contacts",
                  "'A' to view Accounts",
                  "'T' to view Task",
                  "'R' to view Reports",
                  "'E' to exit application\n"};

        public static List<char> actions = new List<char>() 
                { 'H', 'I', 'L', 'C', 'A', 'T', 'R', 'E' };

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

            LeadManagement Leads = new LeadManagement();
            HomeManagement Home = new HomeManagement();

            for (var userChoice = GetUserInput();
                userChoice != actions.IndexOf('E');
                userChoice = GetUserInput())
            {
                if (userChoice.Equals(actions.IndexOf('H')))
                {
                    Home.HomeTab(); // will consist of feed, summary of contacts & interaction tracking, calendar
                }
                else if (userChoice.Equals(actions.IndexOf('I')))
                {
                    Console.WriteLine("Inbox: Ongoing :)\n"); // will consist of conversation                   
                }
                else if (userChoice.Equals(actions.IndexOf('L')))
                {
                    Leads.LeadTab();
                    Console.WriteLine(Leads);
                }
                else if (userChoice.Equals(actions.IndexOf('C')))
                {
                    Console.WriteLine("Contacts: Ongoing :)\n");
                }
                else if (userChoice.Equals(actions.IndexOf('A')))
                {
                    Console.WriteLine("Accounts: Ongoing\n");
                }
                else if (userChoice.Equals(actions.IndexOf('T')))
                {
                    Console.WriteLine("Task: Ongoing\n"); // will consist a task list or to-do list.
                }
                else if (userChoice.Equals(actions.IndexOf('R')))
                {
                    Console.WriteLine("Reports: Ongoing\n"); // will consist of reports (sales and etc)
                }
                else
                {
                    Console.WriteLine("Exiting..");
                }
            }

        static void DisplayUserOption()
        {
            Console.WriteLine("Please choose the tab you want to view.\n" +
                             "Just type a letter then your good to go!\n");

                foreach (var management in Managements)
                {
                    Console.WriteLine(management);
                }
        }

        static int GetUserInput()
            {
                DisplayUserOption();
                var userInput = (Convert.ToChar(Console.ReadLine().ToUpper()));
                var UserActionIndex = actions.IndexOf(userInput);

                if (UserActionIndex != -1)
                {
                    ActionLog(userInput);
                    return UserActionIndex;
                }
                else
                {
                    ActionLog(userInput);
                    var message = "Please try again.";
                    Console.WriteLine(message);

                    return GetUserInput();
                }
            }
        }

        static void ActionLog(char action)
        {
            Managements.Equals(actions.IndexOf(action));
        }

        static void ActionLog(string message)
        {
            Console.WriteLine(message);
        }   
    }
}     

        


