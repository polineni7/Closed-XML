using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustSessions = new HashSet<CustSession>();
            OmsCustomerPrograms = new HashSet<OmsCustomerProgram>();
        }

        public string CmpId { get; set; }
        public string ParentId { get; set; }
        public string Company { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string StatusDb { get; set; }
        public string Office { get; set; }
        public string OfficeShare { get; set; }
        public string ChgEmId { get; set; }
        public DateTime ChgLog { get; set; }
        public string ChgType { get; set; }
        public DateTime? LastRemind { get; set; }
        public string Comment { get; set; }
        public bool? HasOnHand { get; set; }
        public string CustDomain { get; set; }
        public string CustIdentity { get; set; }
        public string CustSharedSecret { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedBy2 { get; set; }

        public virtual ICollection<CustSession> CustSessions { get; set; }
        public virtual ICollection<OmsCustomerProgram> OmsCustomerPrograms { get; set; }
    }
}
