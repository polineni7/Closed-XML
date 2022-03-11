using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class Custaddress
    {
        public string AdId { get; set; }
        public string CmpId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ChgEmId { get; set; }
        public DateTime ChgLog { get; set; }
        public string ChgType { get; set; }
        public string CmpName { get; set; }
    }
}
