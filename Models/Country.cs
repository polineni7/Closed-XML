using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class Country
    {
        public long CtryId { get; set; }
        public int? Rank { get; set; }
        public string CommonName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string LetterCode2 { get; set; }
        public string LetterCode3 { get; set; }
        public string Idnumber { get; set; }
    }
}
