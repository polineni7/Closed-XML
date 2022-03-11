using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsInvTxn
    {
        public long InvTxnId { get; set; }
        public string ItemId { get; set; }
        public string BatchId { get; set; }
        public long? LocationId { get; set; }
        public string PoheaderId { get; set; }
        public string VendId { get; set; }
        public string CmpId { get; set; }
        public long? InvItemId { get; set; }
        public double? Qty { get; set; }
        public double? BegQty { get; set; }
        public double? EndQty { get; set; }
        public DateTime TxnDate { get; set; }
        public double? FxRate { get; set; }
        public string CurrencyCode { get; set; }
        public double? ClientUnitPrice { get; set; }
        public double? VendCurrencyPrice { get; set; }
        public double? VendUnitPrice { get; set; }
        public string TxnType { get; set; }
        public string Action { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? FromLocId { get; set; }
        public string OnHandType { get; set; }
        public string LocationName { get; set; }
        public double? Ocqty { get; set; }

        public virtual CatalogItem Item { get; set; }
    }
}
