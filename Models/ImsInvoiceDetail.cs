using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsInvoiceDetail
    {
        public int InvoiceId { get; set; }
        public string InvoiceNum { get; set; }
        public string PoheaderId { get; set; }
        public DateTime? SubmittoAccount { get; set; }
        public double? InvoiceAmt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ChgLog { get; set; }
        public double? TotProAmt { get; set; }
        public double? ServicCost { get; set; }

        public virtual ImsPoheader Poheader { get; set; }
    }
}
