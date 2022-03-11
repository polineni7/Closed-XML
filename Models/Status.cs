using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class Status
    {
        public string StatusCode { get; set; }
        public string Status1 { get; set; }
        public string Descr { get; set; }
        public int? SortOrder { get; set; }
    }
}
