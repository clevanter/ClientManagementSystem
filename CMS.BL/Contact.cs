using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class Contact
    {
        ContactInformation ForContact = new ContactInformation();

        public string FirstContact()
        {
            ForContact.ContactOwner = Owner.JazminReyes;
            ForContact.LeadSource = "Cold Call";
            ForContact.Honorifics = PersonHonorifics.Ms;
            ForContact.FirstName = "Chelsea";
            ForContact.LastName = "Wang";
            ForContact.AccountName = "Fila PH";
            ForContact.Position = "Art Director";
            ForContact.EmailAdd = "mschelseawang@filaph.com";
            ForContact.Department = "Art Production";
            ForContact.MobileNum = 09242924111;
            ForContact.PhoneNum = 81043384;
            ForContact.BirthDate = "26-02-1996";
            ForContact.Assistant = "Janine Samson";
            ForContact.AssistantPhone = 09122924111;
            ForContact.SkypeID = "live:.cid.f394r92dbrt3e4gh\n";

            Console.WriteLine("Contact Owner: " + ForContact.ContactOwner);
            Console.WriteLine("Lead Source: " + ForContact.LeadSource);
            Console.WriteLine("First Name: " + ForContact.Honorifics + ForContact.FirstName);
            Console.WriteLine("Last Name: " + ForContact.LastName);
            Console.WriteLine("Account Name: " + ForContact.AccountName);
            Console.WriteLine("Position: " + ForContact.Position);
            Console.WriteLine("Email Address: " + ForContact.EmailAdd);
            Console.WriteLine("Department: " + ForContact.Department);
            Console.WriteLine("Mobile Number: " + ForContact.MobileNum);
            Console.WriteLine("Phone Number: " + ForContact.PhoneNum);
            Console.WriteLine("Birth Date: " + ForContact.BirthDate);
            Console.WriteLine("Assistant Name: " + ForContact.Assistant);
            Console.WriteLine("Asssitant Phone Number: " + ForContact.AssistantPhone);
            Console.WriteLine("Skype ID: " + ForContact.SkypeID);

            return "CONTACT";
        }

        public string SecondContact()
        {
            ForContact.ContactOwner = Owner.JazminReyes;
            ForContact.LeadSource = "Cold Call";
            ForContact.Honorifics = PersonHonorifics.Mr;
            ForContact.FirstName = "Nathan";
            ForContact.LastName = "Osteen";
            ForContact.AccountName = "Five Vibe";
            ForContact.Position = "CEO";
            ForContact.EmailAdd = "5vibeNathanOsteen@gmail.com";
            ForContact.Department = "N/A";
            ForContact.MobileNum = 09242924111;
            ForContact.PhoneNum = 81043384;
            ForContact.BirthDate = "39-10-1990";
            ForContact.Assistant = "Calista Choi";
            ForContact.AssistantPhone = 09122924111;
            ForContact.SkypeID = "live:.cid.f394r92dbrt3e4gh";

            Console.WriteLine("Contact Owner: " + ForContact.ContactOwner);
            Console.WriteLine("Lead Source: " + ForContact.LeadSource);
            Console.WriteLine("First Name: " + ForContact.Honorifics + ForContact.FirstName);
            Console.WriteLine("Last Name: " + ForContact.LastName);
            Console.WriteLine("Account Name: " + ForContact.AccountName);
            Console.WriteLine("Position: " + ForContact.Position);
            Console.WriteLine("Email Address: " + ForContact.EmailAdd);
            Console.WriteLine("Department: " + ForContact.Department);
            Console.WriteLine("Mobile Number: " + ForContact.MobileNum);
            Console.WriteLine("Phone Number: " + ForContact.PhoneNum);
            Console.WriteLine("Birth Date: " + ForContact.BirthDate);
            Console.WriteLine("Assistant Name: " + ForContact.Assistant);
            Console.WriteLine("Asssitant Phone Number: " + ForContact.AssistantPhone);
            Console.WriteLine("Skype ID: " + ForContact.SkypeID);

            return "CONTACT";
        }
        public void ThirdContact()
        {
            Console.WriteLine("Lead Source: ");
            ForContact.LeadSource = Console.ReadLine();

            Console.WriteLine("First Name: ");
            ForContact.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            ForContact.LastName = Console.ReadLine();

            Console.WriteLine("Account Name: ");
            ForContact.AccountName = Console.ReadLine();

            Console.WriteLine("Position: ");
            ForContact.Position = Console.ReadLine();

            Console.WriteLine("Email Address: ");
            ForContact.EmailAdd = Console.ReadLine();

            Console.WriteLine("Department: ");
            ForContact.Department = Console.ReadLine();

            Console.WriteLine("Mobile Number: ");
            ForContact.MobileNum = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Phone Number: ");
            ForContact.PhoneNum = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Birth Date: ");
            ForContact.BirthDate = Console.ReadLine();

            Console.WriteLine("Assistant Name: ");
            ForContact.Assistant = Console.ReadLine();

            Console.WriteLine("Asssitant Phone Number: ");
            ForContact.AssistantPhone = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Skype ID: ");
            ForContact.SkypeID = Console.ReadLine();
        }

        public void ListOfContacts()
        {
            
            //Console.WriteLine("INPUT: ");
            //string UserChoice = Console.ReadLine().ToUpper();

            //List<First>

            //var Contacts<AddedContacts> = new <AddedContacts>();
            //Contacts.Add();
            //Contacts.Add(N);

            //var NewContacts = FirstContact();
            //var NewCon = SecondContact();

            //if (UserChoice == "1")
            //{
            //    Console.WriteLine(Contacts[0]);
            //}
            //else if (UserChoice == "2")
            //{
            //    Console.WriteLine(NewCon);
            //}
            //else
            //{
            //    ListOfContactName();
            //}

           
                //Contacts[i] = Contacts[i];

            
            //foreach (var contact in Contacts)
            //{
            //    Console.WriteLine(contact);
            //}
            
        }

        public void ListOfContactName()
        {

            var ContactOptions = new List<string>();
            ContactOptions.Add("To view Ms. Wang Contact, type '1'");
            ContactOptions.Add("To view Mr. Wang Contact, type '2'");

            foreach (var option in ContactOptions)
            {
                Console.WriteLine(option);

            }

            //string UserChoice = Console.ReadLine().ToUpper();
        }

        public void ViewingContactsOption()
        {
            Console.WriteLine("To view existing Contacts type 'V'");
            Console.WriteLine("To create a new Contact type 'C'\n");
            Console.Write("INPUT: \n");
        }
        public void AddedContact()
        {
            FirstContact();
            SecondContact();
            
        }
    }
}
