using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class PrintOptionsExtra
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public double? Cost { get; set; }
        public string Descr { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
