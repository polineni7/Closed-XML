using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsRcvTxn
    {
        public ImsRcvTxn()
        {
            ImsRcvTxnSerials = new HashSet<ImsRcvTxnSerial>();
        }

        public long RcvTxnId { get; set; }
        public string PolineId { get; set; }
        public string PoheaderId { get; set; }
        public string ItemId { get; set; }
        public long LocId { get; set; }
        public double? Qty { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string SupInvNum { get; set; }
        public string RcvNum { get; set; }
        public double? FxRate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ServPro { get; set; }
        public long? RtheaderId { get; set; }
        public string NcReason { get; set; }
        public int? NcResolve { get; set; }
        public string NcDescr { get; set; }
        public int? NonAllocInv { get; set; }
        public double? LabelLineQty { get; set; }
        public string SublineStatus { get; set; }
        public int? QtyResolved { get; set; }

        public virtual CatalogItem Item { get; set; }
        public virtual ImsLocation Loc { get; set; }
        public virtual ImsPoheader Poheader { get; set; }
        public virtual ImsPoline Poline { get; set; }
        public virtual ICollection<ImsRcvTxnSerial> ImsRcvTxnSerials { get; set; }
    }
}
