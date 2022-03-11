using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsRcvTxnHeader
    {
        public ImsRcvTxnHeader()
        {
            ImsCargoLines = new HashSet<ImsCargoLine>();
            ImsCustRcvLines = new HashSet<ImsCustRcvLine>();
        }

        public long RtheaderId { get; set; }
        public string HeaderId { get; set; }
        public string RcvNumber { get; set; }
        public DateTime RcvDate { get; set; }
        public string Descr { get; set; }
        public long? LocId { get; set; }
        public long? LocTypeId { get; set; }
        public double? PieceQty { get; set; }
        public double? WeightLbs { get; set; }
        public double? WeightKgs { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Volume { get; set; }
        public double? TotalLbs { get; set; }
        public double? TotalKgs { get; set; }
        public double? TotalCbm { get; set; }
        public string RcvType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CmpId { get; set; }
        public string Status { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Notes { get; set; }
        public string Vendor { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? LabelQty { get; set; }
        public string Ocaddress { get; set; }

        public virtual ICollection<ImsCargoLine> ImsCargoLines { get; set; }
        public virtual ICollection<ImsCustRcvLine> ImsCustRcvLines { get; set; }
    }
}
