using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OmsCustomerProgram
    {
        public long CustProgId { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string CmpId { get; set; }
        public string ProgramId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Location { get; set; }
        public string ProgramUser1 { get; set; }
        public string ProgramUser2 { get; set; }

        public virtual Customer Cmp { get; set; }
        public virtual OmsProgram Program { get; set; }
    }
}
