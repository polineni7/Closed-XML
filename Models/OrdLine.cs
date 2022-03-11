using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdLine
    {
        public OrdLine()
        {
            OrdLineSubs = new HashSet<OrdLineSub>();
        }

        public string OrdLineId { get; set; }
        public string ParentLineId { get; set; }
        public string OrdDivId { get; set; }
        public long LineOrder { get; set; }
        public string Descr { get; set; }
        public double? Qty { get; set; }
        public double? PriceCustUnit { get; set; }
        public double? PriceCustExt { get; set; }
        public double? PriceVendUnit { get; set; }
        public double? PriceVendExt { get; set; }
        public string VendId { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string ChgType { get; set; }
        public DateTime? LastRemind { get; set; }
        public double? DimLength { get; set; }
        public double? DimWidth { get; set; }
        public double? DimHeight { get; set; }
        public double? DimWeight { get; set; }
        public string OnOrder { get; set; }
        public double? QtyReceived { get; set; }
        public string ProductCode { get; set; }
        public string VendCurrencyCode { get; set; }
        public double? VendCurrencyPrice { get; set; }
        public double? VendExchangeRate { get; set; }
        public string Receipt { get; set; }
        public string Confirm { get; set; }
        public string ManufactureId { get; set; }
        public string Eccn { get; set; }
        public string Sch { get; set; }
        public string Coo { get; set; }
        public string Hts { get; set; }
        public double? Volume { get; set; }
        public string UnitOfDimension { get; set; }
        public string UnitOfWeight { get; set; }
        public double? UnitQty { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ItemId { get; set; }
        public bool HasPickList { get; set; }
        public double? NcQty { get; set; }
        public long? Tier2Id { get; set; }
        public string ImageName { get; set; }
        public string Path { get; set; }
        public string UnspscCode { get; set; }
        public bool? HasSerial { get; set; }

        public virtual ICollection<OrdLineSub> OrdLineSubs { get; set; }
    }
}
