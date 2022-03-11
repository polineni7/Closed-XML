using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocPackingList
    {
        public string OrdDivId { get; set; }
        public bool? Exist { get; set; }
        public DateTime? FormDate { get; set; }
        public string SoldTo { get; set; }
        public string SoldAttn { get; set; }
        public string ShipTo { get; set; }
        public string ShipAttn { get; set; }
        public string HdRe { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public byte? Field5Show { get; set; }
        public byte? Field6Show { get; set; }
        public string StatusDb { get; set; }
    }
}
