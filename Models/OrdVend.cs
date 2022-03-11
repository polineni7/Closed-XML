using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdVend
    {
        public string OrdId { get; set; }
        public string VendId { get; set; }
        public string OrdRecall { get; set; }
        public DateTime OrdDate { get; set; }
        public string OrdVendType { get; set; }
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
        public decimal? OrdFtTotal { get; set; }
        public decimal? OrdTotal { get; set; }
        public string TotalType { get; set; }
        public string TotalTypeTo { get; set; }
        public string HdrOnBehalf { get; set; }
        public string FtAcknowledge { get; set; }
        public string Nb { get; set; }
        public string FtShipmentBy { get; set; }
        public string FtDelivery { get; set; }
        public string FtOnAbout { get; set; }
        public string FtQuestionsContact { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string ChgType { get; set; }
        public string VendPo { get; set; }
        public int ItemCount { get; set; }
        public string OffId { get; set; }
        public string LotDesc { get; set; }
        public byte? AtCost { get; set; }
        public string CurrencyAbbr { get; set; }
        public string StatusDb { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? FxRate { get; set; }
        public double? FxAmt { get; set; }
        public string ConfirmNum { get; set; }
        public string PaymentTerms { get; set; }
        public string Location { get; set; }
        public string OrdDivId { get; set; }
        public string Ipa { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public string Invoice { get; set; }
        public string Performance { get; set; }
        public string ChgVendEmId { get; set; }
        public DateTime? ChgVendDate { get; set; }
        public string LocType { get; set; }
        public string Status { get; set; }
        public long? LocTypeId { get; set; }
        public long? LocId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string StatusConfirmedHelper { get; set; }
    }
}
