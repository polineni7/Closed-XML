using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsCargoLine
    {
        public long CargoId { get; set; }
        public long? RtheaderId { get; set; }
        public double Qty { get; set; }
        public string UnitofWeight { get; set; }
        public double? WeightLbs { get; set; }
        public double? WeightKgs { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Volume { get; set; }
        public double? TotalLbs { get; set; }
        public double? TotalKgs { get; set; }
        public double? TotalCbm { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public double? PrintQty { get; set; }
        public string UnitofMeasure { get; set; }
        public bool? UnAllocate { get; set; }
        public string OrdLineId { get; set; }

        public virtual ImsRcvTxnHeader Rtheader { get; set; }
    }
}
