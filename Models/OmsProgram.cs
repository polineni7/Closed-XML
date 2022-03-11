using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OmsProgram
    {
        public OmsProgram()
        {
            OmsCustomerPrograms = new HashSet<OmsCustomerProgram>();
            OrdHdrs = new HashSet<OrdHdr>();
        }

        public string ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramDesc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<OmsCustomerProgram> OmsCustomerPrograms { get; set; }
        public virtual ICollection<OrdHdr> OrdHdrs { get; set; }
    }
}
