using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocWorkOrderInstr
    {
        public string OrdDivId { get; set; }
        public byte? Exist { get; set; }
        public DateTime? FormDate { get; set; }
        public string ShipCompany { get; set; }
        public string ShipFullName { get; set; }
        public string Instructions { get; set; }
        public string Shipper { get; set; }
        public string Notify { get; set; }
        public string Consignee { get; set; }
        public string Markings { get; set; }
        public string NoTypePkgs { get; set; }
        public string Description { get; set; }
        public string FootAdvise { get; set; }
        public string FootNb { get; set; }
        public string StatusDb { get; set; }
        public double? TotalAmount { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? FxRate { get; set; }
        public double? FxAmt { get; set; }
        public string EstPieceType { get; set; }
        public decimal? EstDkg { get; set; }
        public decimal? ActualDkg { get; set; }
        public decimal? BuyerEstCost { get; set; }
        public decimal? WarehouseActCost { get; set; }
        public decimal? BuyerSell { get; set; }
        public string InsuranceReq { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Dimensions { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
    }
}
