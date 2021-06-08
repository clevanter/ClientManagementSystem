using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BL
{
    public class ContactInformation
    {
        public Owner LeadOwner { get; set; }
        public Owner ContactOwner { get; set; }
        public string ViewLead { get; set; }
        public string CompanyName { get; set; }
        public string AccountName { get; set; }
        public PersonHonorifics Honorifics { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string EmailAdd { get; set; }
        public long MobileNum { get; set; }
        public long PhoneNum { get; set; }
        public string WebsiteLink { get; set; }
        public string LeadSource { get; set; }
        public string LeadStatus { get; set; }
        public string Industry { get; set; }
        public int Employees { get; set; }
        public decimal AnnualRevenue { get; set; }
        public string SkypeID { get; set; }
        public int Rating { get; set; }
        public string Department { get; set; }
        public string BirthDate { get; set; }
        public string Assistant { get; set; }
        public long AssistantPhone { get; set; }
    }
}
