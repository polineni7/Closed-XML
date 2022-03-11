using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class Office
    {
        public string OffId { get; set; }
        public long NextOrd { get; set; }
        public string Name { get; set; }
        public string CmpName { get; set; }
        public string CmpAddress1 { get; set; }
        public string CmpAddress2 { get; set; }
        public string CmpCity { get; set; }
        public string CmpRegion { get; set; }
        public string CmpCountry { get; set; }
        public string CmpPostCode { get; set; }
        public string CmpPhone { get; set; }
        public string CmpFax { get; set; }
        public string CmpEmail { get; set; }
        public string WebmailUrl { get; set; }
        public string CmpReportName { get; set; }
    }
}
