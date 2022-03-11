using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class CatalogItem
    {
        public CatalogItem()
        {
            ImsInvItems = new HashSet<ImsInvItem>();
            ImsInvTxns = new HashSet<ImsInvTxn>();
            ImsPolines = new HashSet<ImsPoline>();
            ImsRcvTxnSerials = new HashSet<ImsRcvTxnSerial>();
            ImsRcvTxns = new HashSet<ImsRcvTxn>();
        }

        public string CatalogId { get; set; }
        public string Ipasku { get; set; }
        public int? Qty { get; set; }
        public string Descr { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ProductInfo { get; set; }
        public string Vendor { get; set; }
        public decimal? ClientUnitPrice { get; set; }
        public string VendCurrency { get; set; }
        public decimal? VendCurrPrice { get; set; }
        public decimal? ExRate { get; set; }
        public decimal? VendUnitPrice { get; set; }
        public int? ProductTierId { get; set; }
        public string Notes { get; set; }
        public string PricingClass { get; set; }
        public string AvailabilityClass { get; set; }
        public int? Availability { get; set; }
        public string ManufactureId { get; set; }
        public string Eccn { get; set; }
        public string Sch { get; set; }
        public string Coo { get; set; }
        public string Hts { get; set; }
        public double? Volume { get; set; }
        public double? Weight { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public string UnitOfDimension { get; set; }
        public string UnitOfWeight { get; set; }
        public double? UnitQty { get; set; }
        public string UnitOfMeasure { get; set; }
        public bool? HasStockable { get; set; }
        public double? Reorder { get; set; }
        public bool? HasSerial { get; set; }
        public string ImageName { get; set; }
        public string Path { get; set; }
        public bool? ViewableToAll { get; set; }
        public string UnspscCode { get; set; }
        public bool? ActiveFlag { get; set; }

        public virtual ICollection<ImsInvItem> ImsInvItems { get; set; }
        public virtual ICollection<ImsInvTxn> ImsInvTxns { get; set; }
        public virtual ICollection<ImsPoline> ImsPolines { get; set; }
        public virtual ICollection<ImsRcvTxnSerial> ImsRcvTxnSerials { get; set; }
        public virtual ICollection<ImsRcvTxn> ImsRcvTxns { get; set; }
    }
}
