using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ReturnedSerial
    {
        public int ReturnId { get; set; }
        public string SerialNum { get; set; }
        public long? LineSubId { get; set; }
        public bool? ReturnFlag { get; set; }
        public long? LocId { get; set; }
        public string Type { get; set; }
        public long? SubId { get; set; }
        public string FileType { get; set; }
    }
}
