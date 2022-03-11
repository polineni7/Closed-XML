using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocMarking
    {
        public string OrdDivId { get; set; }
        public int Pieces { get; set; }
        public string ClientPo { get; set; }
        public string Shipper { get; set; }
        public string Consignee { get; set; }
        public string Attn { get; set; }
    }
}
