using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocPakListSubItem
    {
        public OrdDocPakListSubItem()
        {
            OrdDocPakListSubItemsSerials = new HashSet<OrdDocPakListSubItemsSerial>();
        }

        public long Id { get; set; }
        public string OrdDivId { get; set; }
        public int ItemId { get; set; }
        public int PieceId { get; set; }
        public double? Qty { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public double? TotalQty { get; set; }
        public long? LineOrder { get; set; }
        public string OrdLineId { get; set; }
        public string Type { get; set; }
        public long? TransferId { get; set; }
        public string ItemType { get; set; }
        public string ProductInfo { get; set; }
        public string ManufactureId { get; set; }

        public virtual OrdDocPakListItem Item { get; set; }
        public virtual OrdDocPackListPiece Piece { get; set; }
        public virtual ICollection<OrdDocPakListSubItemsSerial> OrdDocPakListSubItemsSerials { get; set; }
    }
}
