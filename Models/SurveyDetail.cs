using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class SurveyDetail
    {
        public long Id { get; set; }
        public string ConfirmNum { get; set; }
        public bool? IpaclientService { get; set; }
        public bool? Ipawarehouse { get; set; }
        public bool? Ipafinance { get; set; }
        public bool? ThirdpartyInsp { get; set; }
        public string Category { get; set; }
        public string Notes { get; set; }

        public virtual SurveyHeader ConfirmNumNavigation { get; set; }
    }
}
