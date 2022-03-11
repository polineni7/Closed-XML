using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocPakListItem
    {
        public OrdDocPakListItem()
        {
            OrdDocPakListSubItems = new HashSet<OrdDocPakListSubItem>();
        }

        public int ItemId { get; set; }
        public string OrdDivId { get; set; }
        public string OrdLineId { get; set; }
        public double? QtytoAdd { get; set; }
        public double? QtyAllocated { get; set; }
        public double? QtyRemaining { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public double? TotalQty { get; set; }
        public long? LineOrder { get; set; }
        public string Type { get; set; }
        public long? TransferId { get; set; }

        public virtual ICollection<OrdDocPakListSubItem> OrdDocPakListSubItems { get; set; }
    }
}
