using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocTruckerBill
    {
        public string OrdDivId { get; set; }
        public int Sno { get; set; }
        public byte? Exist { get; set; }
        public DateTime? FormDate { get; set; }
        public string CargoOnHand { get; set; }
        public string PlaceofReceipt { get; set; }
        public string PlaceofDelivery { get; set; }
        public int? NumberOfPieces { get; set; }
        public int? FreightClass { get; set; }
        public string TruckingLine { get; set; }
        public string PickupTime { get; set; }
        public string LiftgateRequired { get; set; }
        public string PickupLocation { get; set; }
        public string RefNums { get; set; }
        public string ShipCompany { get; set; }
        public string ShipFirstName { get; set; }
        public string ShipLastName { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostCode { get; set; }
        public string ShipCountry { get; set; }
        public string ShipAttn { get; set; }
        public string ShipPhone { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? FxRate { get; set; }
        public double? FxTransportOrderAmt { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public string ShipCompny2 { get; set; }
        public string Description { get; set; }
        public decimal? TotalTransportOrderAmt { get; set; }
        public string Nb { get; set; }
        public string Invoice { get; set; }
        public string Ipa { get; set; }
        public string Location { get; set; }
        public string PaymentTerm { get; set; }
        public double? FiServiceCost { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string MasterShipmentNum { get; set; }
        public string RefNum { get; set; }
        public double? TotalWeight { get; set; }
        public double? TotalVolume { get; set; }
    }
}
