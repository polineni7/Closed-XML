using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsPoheader
    {
        public ImsPoheader()
        {
            ImsInvoiceDetails = new HashSet<ImsInvoiceDetail>();
            ImsPolines = new HashSet<ImsPoline>();
            ImsRcvTxns = new HashSet<ImsRcvTxn>();
        }

        public string PoheaderId { get; set; }
        public string Ponum { get; set; }
        public string VendId { get; set; }
        public DateTime Podate { get; set; }
        public string Postatus { get; set; }
        public string Podescr { get; set; }
        public double? ClientTotalPrice { get; set; }
        public double? ServiceAmt { get; set; }
        public double? SubTotal { get; set; }
        public double? TaxAmt { get; set; }
        public double? VendTotalCurrencyPrice { get; set; }
        public double? VendTotalPrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string BillLocation { get; set; }
        public string BillAddress1 { get; set; }
        public string BillAddress2 { get; set; }
        public string BillCity { get; set; }
        public string BillRegion { get; set; }
        public string BillCountry { get; set; }
        public string BillPostCode { get; set; }
        public string BillAttn { get; set; }
        public string BillFirstName { get; set; }
        public string BillSecondName { get; set; }
        public string BillPhone { get; set; }
        public string ShipLocation { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostCode { get; set; }
        public string ShipAttn { get; set; }
        public string ShipFirstName { get; set; }
        public string ShipSecondName { get; set; }
        public string ShipPhone { get; set; }
        public long? LocTypeId { get; set; }
        public long? LocId { get; set; }
        public string CmpId { get; set; }
        public string Potype { get; set; }
        public string PaymentTerm { get; set; }
        public string OnAbout { get; set; }
        public string Contact { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string Buyer { get; set; }
        public string Buyer2 { get; set; }
        public DateTime? ShipmentBydate { get; set; }

        public virtual Vendor Vend { get; set; }
        public virtual ICollection<ImsInvoiceDetail> ImsInvoiceDetails { get; set; }
        public virtual ICollection<ImsPoline> ImsPolines { get; set; }
        public virtual ICollection<ImsRcvTxn> ImsRcvTxns { get; set; }
    }
}
