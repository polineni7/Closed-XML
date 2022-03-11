using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class TransferHeader
    {
        public long TransferId { get; set; }
        public long LineSubId { get; set; }
        public DateTime? TransferDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string TransferRef { get; set; }
        public double? Pieces { get; set; }
        public double? TransferVolume { get; set; }
        public double? TransferWeight { get; set; }
        public long? Carrier { get; set; }
        public string FromShipAddress1 { get; set; }
        public string FromShipAddress2 { get; set; }
        public string FromShipAddress3 { get; set; }
        public string FromShipCity { get; set; }
        public string FromShipRegion { get; set; }
        public string FromShipPostCode { get; set; }
        public string FromShipCountry { get; set; }
        public string FromShipPhone { get; set; }
        public long? FromFacilityName { get; set; }
        public string OrdDivId { get; set; }
        public string Nb { get; set; }
        public string SigFileName { get; set; }
        public bool? TransferFlag { get; set; }
        public string FromShipAttn { get; set; }
        public string FromShipFirstName { get; set; }
        public string FromShipSecondName { get; set; }
        public string FileNo { get; set; }
        public string ClientPo { get; set; }
        public string FileDescr { get; set; }
        public string ToShipAttn { get; set; }
        public string ToShipFirstName { get; set; }
        public string ToShipSecondName { get; set; }
        public long? ToFacilityType { get; set; }
        public string ToFacilityName { get; set; }
        public long? ToLocation { get; set; }
        public long? FromFacilityType { get; set; }
        public string ToShipAddress1 { get; set; }
        public string ToShipAddress2 { get; set; }
        public string ToShipAddress3 { get; set; }
        public string ToShipCity { get; set; }
        public string ToShipRegion { get; set; }
        public string ToShipPostCode { get; set; }
        public string ToShipCountry { get; set; }
        public string ToShipPhone { get; set; }
        public string ImageName { get; set; }
        public string Path { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? FiServiceCost { get; set; }
        public int? Sno { get; set; }
    }
}
