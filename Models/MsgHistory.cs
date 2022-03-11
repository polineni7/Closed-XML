using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class MsgHistory
    {
        public string MsgId { get; set; }
        public string OrdId { get; set; }
        public string MsgCategory { get; set; }
        public DateTime? DateSubmit { get; set; }
        public string Message { get; set; }
        public string MsgType { get; set; }
        public short? Control { get; set; }
        public string CreatedBy { get; set; }
        public string Document { get; set; }
        public string Vendor { get; set; }
        public string Partial { get; set; }
        public string Version { get; set; }
        public double? Amount { get; set; }
    }
}
