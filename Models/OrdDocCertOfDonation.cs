using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocCertOfDonation
    {
        public string OrdDivId { get; set; }
        public byte? Exist { get; set; }
        public DateTime? FormDate { get; set; }
        public string ProjectRef { get; set; }
        public string Project { get; set; }
        public string Country { get; set; }
        public string DonationsFrom { get; set; }
        public string DescrOfGoods { get; set; }
        public string ToCustom { get; set; }
        public string FromCustom { get; set; }
        public string ForThePeople { get; set; }
        public string StatusDb { get; set; }
    }
}
