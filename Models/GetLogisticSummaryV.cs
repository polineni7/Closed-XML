using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class GetLogisticSummaryV
    {
        public string OrdId { get; set; }
        public string OrdDivId { get; set; }
        public string Partial { get; set; }
        public string DocumentType { get; set; }
        public string ShipCompany { get; set; }
        public string FxCurrencyCode { get; set; }
        public double FxRate { get; set; }
        public double FxAmt { get; set; }
        public string FxUsd { get; set; }
        public double TotalCost { get; set; }
        public string Status { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public string Invoice { get; set; }
    }
}
