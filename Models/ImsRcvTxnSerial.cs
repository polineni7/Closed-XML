using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsRcvTxnSerial
    {
        public string SerialNum { get; set; }
        public string ItemId { get; set; }
        public string PolineId { get; set; }
        public long? RcvTxnId { get; set; }
        public bool Exist { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? LocId { get; set; }
        public string OnHandType { get; set; }
        public string CmpId { get; set; }
        public double? UnitCost { get; set; }

        public virtual CatalogItem Item { get; set; }
        public virtual ImsRcvTxn RcvTxn { get; set; }
    }
}
