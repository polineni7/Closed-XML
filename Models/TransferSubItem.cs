using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class TransferSubItem
    {
        public int SubItemId { get; set; }
        public string OrdDivId { get; set; }
        public long LineSubId { get; set; }
        public int? ItemId { get; set; }
        public int? PieceId { get; set; }
        public double? Qty { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public double? TotalQty { get; set; }
        public long? LineOrder { get; set; }
        public long? TransferId { get; set; }
    }
}
