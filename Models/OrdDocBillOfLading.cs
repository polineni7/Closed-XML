using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocBillOfLading
    {
        public string OrdDivId { get; set; }
        public int Sno { get; set; }
        public byte? Exist { get; set; }
        public DateTime? FormDate { get; set; }
        public string ShipCompany { get; set; }
        public string ShipFullName { get; set; }
        public string Instructions { get; set; }
        public string Shipper { get; set; }
        public string Notify { get; set; }
        public string Consignee { get; set; }
        public string Vessel { get; set; }
        public string PortOfLoading { get; set; }
        public string PortOfDischarge { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string FreightPayableAt { get; set; }
        public string Markings { get; set; }
        public string NoTypePkgs { get; set; }
        public string Description { get; set; }
        public string FootAdvise { get; set; }
        public string FootNb { get; set; }
        public string StatusDb { get; set; }
        public double? TotalTransportOrderAmt { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? FxRate { get; set; }
        public double? FxTransportOrderAmt { get; set; }
        public string Carrier { get; set; }
        public string PaymentTerm { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public string Invoice { get; set; }
        public string PlaceofReceipt { get; set; }
        public string VoyageNum { get; set; }
        public string TransporTerms { get; set; }
        public string Routing { get; set; }
        public string RefNumbers { get; set; }
        public string CargoOnHand { get; set; }
        public double? FiServiceCost { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string MasterShipmentNum { get; set; }
        public string RefNum { get; set; }
        public double? TotalWeight { get; set; }
        public double? TotalVolume { get; set; }
        public string ContainerWeight { get; set; }
        public string ContainerNum { get; set; }
        public string SealNum { get; set; }
        public string SeaType { get; set; }
        public string SeaQty { get; set; }
    }
}
