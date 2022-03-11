using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class CommodityLibSub
    {
        public string SubId { get; set; }
        public string SubCommodity { get; set; }
        public string MainId { get; set; }

        public virtual CommodityLibMain Main { get; set; }
    }
}
