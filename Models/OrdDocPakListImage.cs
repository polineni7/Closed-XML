using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocPakListImage
    {
        public int DocId { get; set; }
        public string OrdDivId { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public long? FacilityFunction { get; set; }
        public string ImagePath { get; set; }
    }
}
