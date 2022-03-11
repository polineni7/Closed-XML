using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocBillRateHeader
    {
        public int BillHearderId { get; set; }
        public string BillType { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public double? Fxrate { get; set; }
        public string UnitofMeasure { get; set; }
    }
}
