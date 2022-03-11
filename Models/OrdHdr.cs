using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdHdr
    {
        public string OrdId { get; set; }
        public string OrdName { get; set; }
        public DateTime? OrdDate { get; set; }
        public string CmpId { get; set; }
        public string Company { get; set; }
        public string CompanyPo { get; set; }
        public decimal? OrdTotal { get; set; }
        public string Office { get; set; }
        public string OfficeShare { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string ChgType { get; set; }
        public DateTime? LastRemind { get; set; }
        public string OfficeLetterhead { get; set; }
        public string EmpId { get; set; }
        public string OrdValue { get; set; }
        public DateTime? OrdDeadline { get; set; }
        public string AltEmpId { get; set; }
        public string ProgramId { get; set; }

        public virtual OmsProgram Program { get; set; }
    }
}
