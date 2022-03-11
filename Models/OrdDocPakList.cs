using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocPakList
    {
        public string OrdDivId { get; set; }
        public bool? Exist { get; set; }
        public DateTime? FormDate { get; set; }
        public string SoldTo { get; set; }
        public string SoldAttn { get; set; }
        public string ShipTo { get; set; }
        public string ShipAttn { get; set; }
        public string HdRe { get; set; }
        public string ClientPo { get; set; }
        public string Nb { get; set; }
        public string Hd { get; set; }
        public string SigFileName { get; set; }
    }
}
