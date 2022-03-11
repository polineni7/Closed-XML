using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class SurveyHeader
    {
        public SurveyHeader()
        {
            SurveyDetails = new HashSet<SurveyDetail>();
        }

        public string ConfirmNum { get; set; }
        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }

        public virtual ICollection<SurveyDetail> SurveyDetails { get; set; }
    }
}
