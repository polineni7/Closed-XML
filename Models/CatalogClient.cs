using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class CatalogClient
    {
        public string CatalogId { get; set; }
        public string CmpId { get; set; }
        public decimal? ClientUnitPrice { get; set; }
    }
}
