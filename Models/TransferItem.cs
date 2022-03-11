using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class TransferItem
    {
        public int ItemId { get; set; }
        public string OrdDivId { get; set; }
        public long LineSubId { get; set; }
        public double? QtytoAdd { get; set; }
        public double? QtyAllocated { get; set; }
        public double? QtyRemaining { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public double? TotalQty { get; set; }
        public long? LineOrder { get; set; }
        public long? TransferId { get; set; }
        public bool? TransferFlag { get; set; }
    }
}
