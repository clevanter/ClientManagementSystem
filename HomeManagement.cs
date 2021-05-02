using System;
using System.Collections.Generic;


namespace ClientManagementSystem
{
    class HomeManagement
    {
        public static List<string> Updates = new List<string>()
                { "New Lead was added",
                  "New Conversation was added",
                  "New Contact was added",
                  "New Account was added",
                  "New Task was finished",
                  "New Report was ceated\n"};

        public static List<string> NewLeads = new List<string>()
                { "CEW — 12345678903",
                  "HHJ — 12345678901",
                  "LMH — 12345678902\n"};

        public static List<string> NewContacts = new List<string>()
                { "CEW — 12345678903",
                  "HHJ — 12345678901",
                  "LMH — 12345678902\n"};

        public static List<string> CalendarDates = new List<string>()
                { "1 — Deal with ABC Company", 
                  "2 — Meeting with Mr. Chang", 
                  "9 — Submission of Meeting's Minute", 
                  "15 — Presentation of Financial Statement",
                  "18 — Start-Up Seminar", 
                  "23 — Online Consultant", 
                  "31 - Analysis of Sales\n"};
        
        public void HomeTab()
        {
            Console.WriteLine("—————————————Home Tab—————————————\n");

            Console.WriteLine("Feed:");
            DisplayFeed();
            Console.WriteLine("Leads (newly added):");
            DisplayLeads();
            Console.WriteLine("Contacts (newly added):");
            DisplayContacts();
            Console.WriteLine("Calendar:");
            DisplayCalendar();

            Console.WriteLine("—————————————Home Tab—————————————\n");
        }

        static void DisplayFeed()
        {
            for (int i = 0; i < Updates.Count; i++)
            {
                Console.WriteLine(Updates[i]); 
            }
        }

       static void DisplayLeads()
       {
            foreach (var lead in NewLeads)
            {
                Console.WriteLine(lead);
            }
        }

        static void DisplayContacts()
        {
            for (int i = 0; i < NewContacts.Count; i++)
            {
                Console.WriteLine(NewContacts[i]);
            }
        }

        static void DisplayCalendar()
        {
            foreach (var date in CalendarDates)
            {
                Console.WriteLine(date);
            }
        }

    }
}
