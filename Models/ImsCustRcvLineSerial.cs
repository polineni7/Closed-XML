using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsCustRcvLineSerial
    {
        public string SerialNum { get; set; }
        public long CrlineId { get; set; }
        public bool? Exist { get; set; }
        public long LocId { get; set; }
    }
}
