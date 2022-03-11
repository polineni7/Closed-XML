using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdRequest
    {
        public string CmpId { get; set; }
        public long Item { get; set; }
        public double Qty { get; set; }
        public string Descr { get; set; }
        public DateTime DateAdded { get; set; }
        public string Notes { get; set; }
        public string ProductInfo { get; set; }
        public string VendId { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalPrice { get; set; }
        public string PricingClass { get; set; }
        public int? Availability { get; set; }
        public string AvailabilityClass { get; set; }
        public string ItemId { get; set; }
        public string FileName { get; set; }
        public string FileDescr { get; set; }
    }
}
