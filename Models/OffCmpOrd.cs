using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OffCmpOrd
    {
        public string OffId { get; set; }
        public string CmpId { get; set; }
        public long NextOrd { get; set; }
    }
}
