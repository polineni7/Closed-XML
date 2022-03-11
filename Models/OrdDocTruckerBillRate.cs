using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocTruckerBillRate
    {
        public int TruckerRateId { get; set; }
        public string OrdDivId { get; set; }
        public string Item { get; set; }
        public string Currency { get; set; }
        public double? Fxrate { get; set; }
        public string UnitOfMeasure { get; set; }
        public double? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Minimum { get; set; }
        public decimal? CurrencyTotal { get; set; }
        public decimal? Usdtotal { get; set; }
        public int? Sno { get; set; }

        public virtual OrdDiv OrdDiv { get; set; }
    }
}
