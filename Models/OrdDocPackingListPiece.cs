using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocPackingListPiece
    {
        public string OrdDivId { get; set; }
        public short PieceNo { get; set; }
        public double? DimLength { get; set; }
        public double? DimWidth { get; set; }
        public double? DimHeight { get; set; }
        public double? DimWeight { get; set; }
    }
}
