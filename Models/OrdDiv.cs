using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDiv
    {
        public OrdDiv()
        {
            OrdDocAirwayBillRates = new HashSet<OrdDocAirwayBillRate>();
            OrdDocBillOfLadingRates = new HashSet<OrdDocBillOfLadingRate>();
            OrdDocTruckerBillRates = new HashSet<OrdDocTruckerBillRate>();
        }

        public string OrdDivId { get; set; }
        public string OrdId { get; set; }
        public int? OrdDiv1 { get; set; }
        public DateTime? OrdDate { get; set; }
        public string BillCompany { get; set; }
        public string BillTitle { get; set; }
        public string BillFirstName { get; set; }
        public string BillLastName { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillAddress3 { get; set; }
        public string BillCity { get; set; }
        public string BillRegion { get; set; }
        public string BillPostCode { get; set; }
        public string BillCountry { get; set; }
        public string BillPhone { get; set; }
        public string BillFax { get; set; }
        public string BillEmail { get; set; }
        public string ShipCompany { get; set; }
        public string ShipTitle { get; set; }
        public string ShipFirstName { get; set; }
        public string ShipLastName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostCode { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPhone { get; set; }
        public string ShipFax { get; set; }
        public decimal? OrdExTotal { get; set; }
        public decimal? OrdVendTotal { get; set; }
        public decimal? OrdFtTotal { get; set; }
        public decimal? OrdTotal { get; set; }
        public string TotalType { get; set; }
        public string TotalTypeTo { get; set; }
        public string HdRe { get; set; }
        public string FtDeliveryDelay { get; set; }
        public string FtTransitTime { get; set; }
        public string FtPriceValidity { get; set; }
        public string FtPaymentTerms { get; set; }
        public string FtSig { get; set; }
        public string StatusDb { get; set; }
        public string StatusOr { get; set; }
        public DateTime? O01date { get; set; }
        public DateTime? O03date { get; set; }
        public DateTime? O05date { get; set; }
        public DateTime? O07date { get; set; }
        public DateTime? O09date { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string ChgType { get; set; }
        public long? Attachments { get; set; }
        public string Nb { get; set; }
        public DateTime? O11date { get; set; }
        public DateTime? O04date { get; set; }
        public DateTime? O00date { get; set; }
        public string StatusOrlast { get; set; }
        public DateTime? OrdDeadline { get; set; }
        public string HdrOnBehalf { get; set; }
        public string FtAcknowledge { get; set; }
        public string FtShipmentBy { get; set; }
        public string FtDelivery { get; set; }
        public string FtOnAbout { get; set; }
        public string FtQuestionsContact { get; set; }
        public byte? HasAwb { get; set; }
        public byte? HasBol { get; set; }
        public byte? HasPkl { get; set; }
        public byte? HasCod { get; set; }
        public DateTime? StatusDeadline { get; set; }
        public DateTime? O99date { get; set; }
        public byte HasWoi { get; set; }
        public byte HasOth { get; set; }
        public byte HasIns { get; set; }
        public string FtBankDetails { get; set; }
        public DateTime? O08date { get; set; }
        public DateTime? O12date { get; set; }
        public DateTime? O17date { get; set; }
        public DateTime? O18date { get; set; }
        public byte? HasCou { get; set; }
        public byte HasTkb { get; set; }
        public byte? HasCfe { get; set; }
        public byte? HasPac { get; set; }
        public byte? HasPsi { get; set; }
        public byte? HasCer { get; set; }
        public byte? HasCoo { get; set; }
        public byte? HasBfl { get; set; }
        public byte? HasMak { get; set; }
        public DateTime? Processed { get; set; }
        public DateTime? Dispached { get; set; }
        public DateTime? Delivered { get; set; }
        public DateTime? WorkOrdertoWarehouse { get; set; }
        public DateTime? LastItemDelivered { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? OrderCompleted { get; set; }
        public DateTime? WarehousePackCompleted { get; set; }
        public DateTime? PickUpRequested { get; set; }
        public DateTime? DispatchFromIpa { get; set; }
        public DateTime? ArriveFriedForwarder { get; set; }
        public DateTime? AwbinstructionsSent { get; set; }
        public DateTime? PromDelivDate { get; set; }
        public string Descr { get; set; }
        public string VendorId { get; set; }
        public int? FtDelivDelayDays { get; set; }
        public int? FtTransitDays { get; set; }
        public string FtDeliverTo { get; set; }
        public int? FtDeliverDays { get; set; }
        public byte? HasIwo { get; set; }
        public string Version { get; set; }
        public byte? HasCtx { get; set; }
        public byte? HasCog { get; set; }
        public DateTime? EstDelivDate { get; set; }
        public DateTime? QuotedShipDate { get; set; }
        public DateTime? QuotedArrivalDate { get; set; }
        public string SigFileName { get; set; }
        public double? QtdMargin { get; set; }
        public bool? HasQtd { get; set; }
        public string OriginServicePro { get; set; }
        public string FobnamedPlace { get; set; }
        public string TransitServicePro { get; set; }
        public string Carrier { get; set; }
        public string DestServicePro { get; set; }
        public DateTime? ApprovalSchedulePickUp { get; set; }
        public string InvHeader { get; set; }
        public double? QtdServiceMargin { get; set; }
        public string DestinationCity { get; set; }
        public double? ShippingServices { get; set; }
        public double? Insurance { get; set; }
        public byte? HasTl { get; set; }
        public DateTime? PriceValidDate { get; set; }
        public long? FobnamedLocation { get; set; }
        public int? PreShipmentSerDays { get; set; }
        public DateTime? O0fdate { get; set; }
        public DateTime? O13date { get; set; }
        public DateTime? O0cdate { get; set; }
        public DateTime? O14date { get; set; }
        public DateTime? O15date { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string CompanyPo { get; set; }
        public string ProgramId { get; set; }

        public virtual ICollection<OrdDocAirwayBillRate> OrdDocAirwayBillRates { get; set; }
        public virtual ICollection<OrdDocBillOfLadingRate> OrdDocBillOfLadingRates { get; set; }
        public virtual ICollection<OrdDocTruckerBillRate> OrdDocTruckerBillRates { get; set; }
    }
}
