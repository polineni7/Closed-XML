using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class CustomsTaxis
    {
        public string OrdDivId { get; set; }
        public DateTime? FormDate { get; set; }
        public string ShipCompany { get; set; }
        public string Description { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? FxRate { get; set; }
        public decimal? FxAmt { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public string Invoice { get; set; }
        public string PaymentTerm { get; set; }
        public double? FiServiceCost { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
    }
}
