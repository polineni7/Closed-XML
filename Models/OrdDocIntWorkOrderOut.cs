using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocIntWorkOrderOut
    {
        public int Id { get; set; }
        public string OrdDivId { get; set; }
        public DateTime? Date { get; set; }
        public string PieceType { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Dkg { get; set; }
        public decimal? WeightLbs { get; set; }
        public decimal? WarehouseCost { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Uom { get; set; }
        public string Uow { get; set; }
        public string RefId { get; set; }
    }
}
