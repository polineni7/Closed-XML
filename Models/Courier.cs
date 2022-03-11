using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class Courier
    {
        public string OrdDivId { get; set; }
        public DateTime? Cdate { get; set; }
        public string ShipCompany { get; set; }
        public string Notes { get; set; }
        public string FxcurCode { get; set; }
        public double? FxExRate { get; set; }
        public decimal? Fxtotcost { get; set; }
        public decimal? Usdtotcost { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public string Invoice { get; set; }
        public string PaymentTerm { get; set; }
        public double? FiServiceCost { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
    }
}
