using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocAirwayBill
    {
        public string OrdDivId { get; set; }
        public byte? Exist { get; set; }
        public DateTime? FormDate { get; set; }
        public string ShipCompany { get; set; }
        public string ShipFullName { get; set; }
        public string OrdName { get; set; }
        public string CargoOnHand { get; set; }
        public string RatePerKg { get; set; }
        public string ApproxDim { get; set; }
        public double? ApproxWeight { get; set; }
        public double? CustomsTotal { get; set; }
        public string PhoneContact { get; set; }
        public string Shipper { get; set; }
        public string Markings { get; set; }
        public string Notify { get; set; }
        public string Consignee { get; set; }
        public string FootAdvise { get; set; }
        public string FootNb { get; set; }
        public string StatusDb { get; set; }
        public double? TotalCargoCharges { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? FxRate { get; set; }
        public double? FxTransportOrderAmt { get; set; }
        public string PaymentTerm { get; set; }
        public double? TotalWeight { get; set; }
        public double? TotalVolume { get; set; }
        public double? TotalChargeableWeight { get; set; }
        public string RefNumbers { get; set; }
        public string RefNum { get; set; }
        public string PlaceofReciept { get; set; }
        public string AirportofDeparture { get; set; }
        public string AirportofDestination { get; set; }
        public string PlaceofDelivery { get; set; }
        public string Airline { get; set; }
        public string Routing { get; set; }
        public double? FiServiceCost { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string MasterShipmentNum { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public string Invoice { get; set; }
    }
}
