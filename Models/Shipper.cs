using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class Shipper
    {
        public int ShipId { get; set; }
        public string Company { get; set; }
        public string BaseUrl { get; set; }
        public string TrackUrl { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
    }
}
