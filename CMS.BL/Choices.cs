using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class Choices
    {
         private static List<string> Managements = new List<string>()
                    { "To view Home --------------- type H",
                      "To view Leads -------------- type L",
                      "To view Contacts ----------- type C",
                      "To view Accounts ----------- type A",
                      "To view Deals -------------- type D",
                      "To view Sales -------------- type S",
                      "To Exit Application -------- type E\n"};

        
        Lead existingLead = new Lead();

        public void DisplayAction()
        {
            foreach (var manage in Managements)
            {
                Console.WriteLine(manage);
            }
            Console.Write("INPUT: ");
        }

        public void TheChoice()
        {
            string UserChoice = Console.ReadLine().ToUpper();
            Lead LeadOptions = new Lead();
            Contact ContactOptions = new Contact();
            Choices molla = new Choices();

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
                        ForViewing();
                    }
                    else if (UserChoice.Equals("C"))
                    {
                        ForCreating();
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
                    ContactOptions.ViewingContactsOption();
                    UserChoice = Console.ReadLine().ToUpper();

                    if (UserChoice.Equals("V"))
                    {
                        ContactOptions.ListOfContactName();
                        ContactOptions.ListOfContacts();
                    }
                    else if (UserChoice.Equals("C"))
                    {
                        ForCreating();
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
                    TheChoice();
                    break;
            }
        }

        public void ForViewing()
        {
            Console.Write("INPUT: ");
            string UserChoice = Console.ReadLine().ToUpper();

            switch (UserChoice)
            {
                case "1":
                    Lead DisplayFirstLead = new Lead();
                    DisplayFirstLead.FirstLead();
                    break;

                case "2":
                    Lead DisplaySecondLead = new Lead();
                    DisplaySecondLead.SecondLead();
                    break;

                default:
                    existingLead.ViewingExistingLeads();
                    Console.WriteLine("Input: ");
                    UserChoice = Console.ReadLine().ToUpper();
                    break;
            }
        }

        public void ForCreating()
        {
            Lead LeadOptions = new Lead();
            Lead CreateLead = new Lead();
            CreateLead.ThirdLead();
            LeadOptions.ViewingLeadOptions();
            string UserChoice = Console.ReadLine().ToUpper();

            switch (UserChoice)
            {
                case "V":
                    existingLead.ViewingExistingLeads();
                    UserChoice = Console.ReadLine().ToUpper();


                    if (UserChoice == "1")
                    {
                        Lead DisplayFirstLead = new Lead();
                        DisplayFirstLead.FirstLead();
                    }
                    else if (UserChoice == "2")
                    {
                        Lead DisplaySecondLead = new Lead();
                        DisplaySecondLead.SecondLead();
                    }
                    else if (UserChoice == "3")
                    {
                        Lead DisplayNewLead = new Lead();
                        DisplayNewLead.DisplayNewLead();
                    }
                    else
                    {
                        Console.WriteLine("Program is exiting");
                    }

                    break;
                case "C":
                    CreateLead.ThirdLead();
                    break;
                default:
                    Console.WriteLine("Program is exiting");
                    break;
            }
        }
        public void ForUpdating()
        {
            Console.WriteLine("To update an existing Lead, type 'U'");

        }
    }
}