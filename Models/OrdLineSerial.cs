using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdLineSerial
    {
        public string SerialNum { get; set; }
        public string OrdLineId { get; set; }
        public long LineSubId { get; set; }
        public bool? Exist { get; set; }
        public long? LocId { get; set; }
        public bool? TranferExist { get; set; }
        public bool? HasAlloc { get; set; }
    }
}
