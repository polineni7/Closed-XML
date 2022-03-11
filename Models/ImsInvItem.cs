using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsInvItem
    {
        public long InvItemId { get; set; }
        public string ItemId { get; set; }
        public string BatchId { get; set; }
        public long LocationId { get; set; }
        public double Qty { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string OnHandType { get; set; }
        public string CmpId { get; set; }
        public double UnitCost { get; set; }

        public virtual CatalogItem Item { get; set; }
    }
}
