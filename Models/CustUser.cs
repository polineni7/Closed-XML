using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class CustUser
    {
        public string CmpId { get; set; }
        public string UserId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
