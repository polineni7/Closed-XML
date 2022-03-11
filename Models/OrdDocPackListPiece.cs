using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocPackListPiece
    {
        public OrdDocPackListPiece()
        {
            OrdDocPakListSubItems = new HashSet<OrdDocPakListSubItem>();
        }

        public int Id { get; set; }
        public string OrdDivId { get; set; }
        public DateTime? Date { get; set; }
        public string PieceType { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public double? Volume { get; set; }
        public decimal? WeightLbs { get; set; }
        public decimal? WeightKgs { get; set; }
        public string Image { get; set; }
        public string Path { get; set; }
        public string Uom { get; set; }
        public string Uow { get; set; }
        public string RefId { get; set; }
        public string Type { get; set; }
        public long? TransferId { get; set; }

        public virtual ICollection<OrdDocPakListSubItem> OrdDocPakListSubItems { get; set; }
    }
}
