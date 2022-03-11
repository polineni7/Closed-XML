using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class Employee
    {
        public string EmpId { get; set; }
        public string UserPass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Office { get; set; }
        public int Access { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string ChgType { get; set; }
        public string Title { get; set; }
        public string EmailLogin { get; set; }
        public string EmailPass { get; set; }
        public string Initials { get; set; }
        public string SignatureFileName { get; set; }
        public string SignatureFileName2 { get; set; }
    }
}
