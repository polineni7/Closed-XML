using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class InvoiceDetail
    {
        public int InvoiceId { get; set; }
        public string InvoiceNum { get; set; }
        public string OrdDivId { get; set; }
        public string VendId { get; set; }
        public DateTime? SubmittoAccount { get; set; }
        public double? Servicecost { get; set; }
        public string CreatedBy { get; set; }
        public double? TotProIoamt { get; set; }
        public double? VendIoamt { get; set; }
        public string Iotype { get; set; }
        public string ServiceType { get; set; }
        public string OrdRecall { get; set; }
        public DateTime? ChgLog { get; set; }
        public int? Sno { get; set; }
    }
}
