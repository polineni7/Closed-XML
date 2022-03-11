using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsPoline
    {
        public ImsPoline()
        {
            ImsRcvTxns = new HashSet<ImsRcvTxn>();
        }

        public string PolineId { get; set; }
        public string PolineNum { get; set; }
        public string PoheaderId { get; set; }
        public string ItemId { get; set; }
        public long? LocId { get; set; }
        public double? QtyOrdered { get; set; }
        public double? QtyReceived { get; set; }
        public double? FxRate { get; set; }
        public string FxCurrencyCode { get; set; }
        public double? ClientUnitPrice { get; set; }
        public double? ClientTotalPrice { get; set; }
        public double? VendCurrencyPrice { get; set; }
        public double? VendUnitPrice { get; set; }
        public double? VendTotalPrice { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public double? NcQty { get; set; }

        public virtual CatalogItem Item { get; set; }
        public virtual ImsLocation Loc { get; set; }
        public virtual ImsPoheader Poheader { get; set; }
        public virtual ICollection<ImsRcvTxn> ImsRcvTxns { get; set; }
    }
}
