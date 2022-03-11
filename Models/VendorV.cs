using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class VendorV
    {
        public string VendId { get; set; }
        public long Rank { get; set; }
        public string AcctNo { get; set; }
        public string Company { get; set; }
        public string TitlePri { get; set; }
        public string FirstNamePri { get; set; }
        public string LastNamePri { get; set; }
        public string TitleSec { get; set; }
        public string FirstNameSec { get; set; }
        public string LastNameSec { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Misc { get; set; }
        public string Descr { get; set; }
        public string Product { get; set; }
        public string Comment { get; set; }
        public string StatusDb { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string ChgType { get; set; }
        public long VendTier2Id { get; set; }
        public int VendTier1Id { get; set; }
        public string VendTier { get; set; }
    }
}
