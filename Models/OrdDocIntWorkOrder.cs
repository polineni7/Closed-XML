using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocIntWorkOrder
    {
        public string OrdDivId { get; set; }
        public string EstPieceType { get; set; }
        public decimal? EstDkg { get; set; }
        public decimal? ActualDkg { get; set; }
        public decimal? BuyerEstCost { get; set; }
        public decimal? WarehouseActualCost { get; set; }
        public decimal? BuyerSell { get; set; }
        public string InsuranceRequired { get; set; }
        public string RestrictedWeight { get; set; }
        public string RestrictedDimensions { get; set; }
        public string SpecialNotes { get; set; }
        public DateTime? FormDate { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? FxRate { get; set; }
        public double? FxTransportOrderAmt { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public string Invoice { get; set; }
        public string PaymentTerm { get; set; }
        public double? FiServiceCost { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string VendorId { get; set; }
        public string ShipCompany { get; set; }
    }
}
