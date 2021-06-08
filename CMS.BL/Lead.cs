using System;
using System.Collections.Generic;

namespace CMS.BL
{
    public class Lead
    {

        ContactInformation ForLead = new ContactInformation();

        public void FirstLead()
        {
            
            ForLead.CompanyName = "Nylon Manila";
            ForLead.Honorifics = PersonHonorifics.Ms;
            ForLead.FirstName = ". Dana";
            ForLead.LastName = "Yoon";
            ForLead.Position = "CEO";
            ForLead.EmailAdd = "danayoonofnylon@gmail.com";
            ForLead.MobileNum = 09215125385;
            ForLead.PhoneNum = 8696166;
            ForLead.WebsiteLink = "https://nylonmanila.com/";
            ForLead.LeadSource = "Event";
            ForLead.LeadStatus = "Active";
            ForLead.Industry = "Fashion";
            ForLead.Employees = 49;
            ForLead.AnnualRevenue = 2100114;
            ForLead.SkypeID = "live:.cid.f394r92dbrt3e8bf";
            ForLead.Rating = 4;

            Console.WriteLine("\nCompany Name:  " + ForLead.CompanyName);
            Console.WriteLine("First Name:      " + ForLead.Honorifics + ForLead.FirstName);
            Console.WriteLine("Last Name:       " + ForLead.LastName);
            Console.WriteLine("Position:        " + ForLead.Position);
            Console.WriteLine("E-mail Address:  " + ForLead.EmailAdd);
            Console.WriteLine("Mobile Number:   " + ForLead.MobileNum);
            Console.WriteLine("Phone Number:    " + ForLead.PhoneNum);
            Console.WriteLine("Website Link:    " + ForLead.WebsiteLink);
            Console.WriteLine("Lead Source:     " + ForLead.LeadSource);
            Console.WriteLine("Lead Status:     " + ForLead.LeadStatus);
            Console.WriteLine("Industry:        " + ForLead.Industry);
            Console.WriteLine("Employees:       " + ForLead.Employees);
            Console.WriteLine("Annual Revenue: P" + ForLead.AnnualRevenue);
            Console.WriteLine("Rating:          " + ForLead.Rating);
            Console.WriteLine("Skype Id:        " + ForLead.SkypeID);
        }

        public void SecondLead()
        {

            ForLead.CompanyName = "Vogue";
            ForLead.Honorifics = PersonHonorifics.Mrs;
            ForLead.FirstName = ". Vela";
            ForLead.LastName = "Vogue";
            ForLead.Position = "CEO";
            ForLead.EmailAdd = "VogueVela@gmail.com";
            ForLead.MobileNum = 09215125542;
            ForLead.PhoneNum = 4366442;
            ForLead.WebsiteLink = "https://vogue.com/";
            ForLead.LeadSource = "Meeting";
            ForLead.LeadStatus = "Active";
            ForLead.Industry = "Fashion";
            ForLead.Employees = 112;
            ForLead.AnnualRevenue = 2320114;
            ForLead.SkypeID = "live:.cid.f394r92dbrt3e8bf";
            ForLead.Rating = 4;

            Console.WriteLine("\nCompany Name:   " + ForLead.CompanyName);
            Console.WriteLine("First Name:       " + ForLead.Honorifics + ForLead.FirstName);
            Console.WriteLine("Last Name:        " + ForLead.LastName);
            Console.WriteLine("Position:         " + ForLead.Position);
            Console.WriteLine("E-mail Address:   " + ForLead.EmailAdd);
            Console.WriteLine("Mobile Number:    " + ForLead.MobileNum);
            Console.WriteLine("Phone Number:     " + ForLead.PhoneNum);
            Console.WriteLine("Website Link:     " + ForLead.WebsiteLink);
            Console.WriteLine("Lead Source:      " + ForLead.LeadSource);
            Console.WriteLine("Lead Status:      " + ForLead.LeadStatus);
            Console.WriteLine("Industry:         " + ForLead.Industry);
            Console.WriteLine("Employees:        " + ForLead.Employees);
            Console.WriteLine("Annual Revenue:  P" + ForLead.AnnualRevenue);
            Console.WriteLine("Rating:           " + ForLead.Rating);
            Console.WriteLine("Skype Id:         " + ForLead.SkypeID);
        }

        public void ThirdLead()
        {
            Console.WriteLine("Please answer the following questions!");

            Console.Write("Company Name: ");
            ForLead.CompanyName = Console.ReadLine();

            Console.Write("First Name: ");
            ForLead.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            ForLead.LastName = Console.ReadLine();

            Console.Write("Title Or Position: ");
            ForLead.Position = Console.ReadLine();

            Console.Write("E-mail Address: ");
            ForLead.EmailAdd = Console.ReadLine();

            Console.Write("Mobile Number: ");
            ForLead.MobileNum = Convert.ToInt64(Console.ReadLine());

            Console.Write("Phone Number: ");
            ForLead.PhoneNum = Convert.ToInt64(Console.ReadLine());

            Console.Write("Website Link: ");
            ForLead.WebsiteLink = Console.ReadLine();

            Console.Write("Lead Source: ");
            ForLead.LeadSource = Console.ReadLine();

            Console.Write("Lead Status: ");
            ForLead.LeadStatus = Console.ReadLine();

            Console.Write("Industry: ");
            ForLead.Industry = Console.ReadLine();

            Console.Write("Number Of Employees: ");
            ForLead.Employees = int.Parse(Console.ReadLine());

            Console.Write("Annual Revenue: ");
            ForLead.AnnualRevenue = Convert.ToInt64(Console.ReadLine());

            Console.Write("Rating: ");
            ForLead.Rating = int.Parse(Console.ReadLine());

            Console.Write("Skype Id: ");
            ForLead.SkypeID = Console.ReadLine();

            DisplayNewLead();

            //Console.WriteLine("\nCompany Name:  " + ForLead.CompanyName);
            //Console.WriteLine("First Name:  " + ForLead.FirstName);
            //Console.WriteLine("Last Name:  " + ForLead.LastName);
            //Console.WriteLine("Position:  " + ForLead.Position);
            //Console.WriteLine("E-mail Address:  " + ForLead.EmailAdd);
            //Console.WriteLine("Mobile Number:  " + ForLead.MobileNum);
            //Console.WriteLine("Phone Number:  " + ForLead.PhoneNum);
            //Console.WriteLine("Website Link:  " + ForLead.WebsiteLink);
            //Console.WriteLine("Lead Source:  " + ForLead.LeadSource);
            //Console.WriteLine("Lead Status:  " + ForLead.LeadStatus);
            //Console.WriteLine("Industry:  " + ForLead.Industry);
            //Console.WriteLine("Number Of Employees:  " + ForLead.Employees);
            //Console.WriteLine("Annual Revenue:  P" + ForLead.AnnualRevenue);
            //Console.WriteLine("Rating:  " + ForLead.Rating);
            //Console.WriteLine("Skype Id:  " + ForLead.SkypeID);

        }
        public string DisplayNewLead()
        {
            Console.WriteLine("\nCompany Name:  " + ForLead.CompanyName);
            Console.WriteLine("First Name:  " + ForLead.FirstName);
            Console.WriteLine("Last Name:  " + ForLead.LastName);
            Console.WriteLine("Position:  " + ForLead.Position);
            Console.WriteLine("E-mail Address:  " + ForLead.EmailAdd);
            Console.WriteLine("Mobile Number:  " + ForLead.MobileNum);
            Console.WriteLine("Phone Number:  " + ForLead.PhoneNum);
            Console.WriteLine("Website Link:  " + ForLead.WebsiteLink);
            Console.WriteLine("Lead Source:  " + ForLead.LeadSource);
            Console.WriteLine("Lead Status:  " + ForLead.LeadStatus);
            Console.WriteLine("Industry:  " + ForLead.Industry);
            Console.WriteLine("Number Of Employees:  " + ForLead.Employees);
            Console.WriteLine("Annual Revenue:  P" + ForLead.AnnualRevenue);
            Console.WriteLine("Rating:  " + ForLead.Rating);
            Console.WriteLine("Skype Id:  " + ForLead.SkypeID);

            return "LEAD ADDED";

        }
        public void ViewingLeadOptions()
        {
            Console.WriteLine("To view existing Leads type 'V'");
            Console.WriteLine("To create a new Lead type 'C'\n");
            Console.Write("INPUT: \n");

        }

        public void ViewingExistingLeads()
        {
            ForLead.ViewLead = PersonHonorifics.Ms + ". Dana Yoon";
            Console.WriteLine(ForLead.ViewLead);

            ForLead.ViewLead = PersonHonorifics.Mrs + ". Vela Vogue\n";
            Console.WriteLine(ForLead.ViewLead);

            

            Console.WriteLine("To view the contact of Ms. Yoon, type 1");
            Console.WriteLine("To view the contact of Mrs. Vogue, type 2");
            Console.Write("To view newly added, type 3\n"); 

        }

        public void AddLead()
        {
            var NewLead = DisplayNewLead();

            List<string> _createLead = new List<string>();

            _createLead.Add(NewLead);

            foreach (var item in _createLead)
            {
                Console.WriteLine(item);
                
            }
        }
    }
}
