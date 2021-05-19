using System;
using System.Collections.Generic;
using CMS.BL;


namespace CMS.UI
{
    class Program
    {
        private static List<string> Managements = new List<string>()
                    { "To view Home --------------- type H",
                      "To view Leads -------------- type L",
                      "To view Contacts ----------- type C",
                      "To view Accounts ----------- type A",
                      "To view Deals -------------- type D",
                      "To view Sales -------------- type S",
                      "To Exit Application -------- type E\n"};

        static void Main(string[] args)
        {
            UserManagement ToLogin = new UserManagement();
            Console.WriteLine("Verimk: Your #1 Client Management Software\n");
            Console.WriteLine("Please LOG-IN\n");
            ToLogin.username = "Clevanter325";
            ToLogin.password = "12345678";
            ToLogin.Admin();
            DisplayAction();
            UserOption();  
        }

        static void DisplayAction()
        {
            foreach (var manage in Managements)
            {
                Console.WriteLine(manage);
            }
            Console.Write("INPUT: ");
        }

        static void UserOption()
        {
            string UserChoice = Console.ReadLine().ToUpper();
            Lead existingLead = new Lead();
            Lead LeadOptions = new Lead();
            

            switch (UserChoice)
            {
                case "H":
                    Console.WriteLine("Home");
                    break;

                case "L":
                    Console.WriteLine("———————————————— Lead ————————————————\n");
                    LeadOptions.ViewingLeadOptions();
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice.Equals("V"))
                    {
                        existingLead.ViewingExistingLeads();
                        Console.Write("INPUT: ");
                        UserChoice = Console.ReadLine().ToUpper();

                        switch (UserChoice)
                        {
                            case "1":
                                Lead FirstLead = new Lead();
                                FirstLead.firstLead();
                                break;

                            case "2":
                                Lead SecondLead= new Lead();
                                SecondLead.secondLead();
                                break;

                            default:
                                existingLead.ViewingExistingLeads();
                                Console.WriteLine("Input: ");
                                UserChoice = Console.ReadLine().ToUpper();
                                break;
                        }

                    }
                    else if (UserChoice.Equals("C"))
                    {
                        Lead ThirdLead = new Lead();
                        ThirdLead.thirdLead();
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            LeadOptions.ViewingLeadOptions();
                            Console.WriteLine("Input: ");
                            UserChoice = Console.ReadLine().ToUpper();
                            Console.WriteLine("Program is existing");
                        }
                    }
                    break;

                case "C":
                    Console.WriteLine("———————————————— Contacts ————————————————\n");
                    break;
                case "A":
                    Console.WriteLine("———————————————— Accounts ————————————————\n");
                    break;
                case "D":
                    Console.WriteLine("———————————————— Deals ————————————————\n");
                    break;
                case "S":
                    Console.WriteLine("———————————————— Sales ————————————————\n");
                    break;
                case "E":
                    Console.WriteLine("Bye");
                    break;
                default:
                    DisplayAction();
                    UserOption();
                    break;

            }
        }
    }
}





