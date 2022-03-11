using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsCustRcvLine
    {
        public long CrlineId { get; set; }
        public long RtheaderId { get; set; }
        public string ItemId { get; set; }
        public double? Qty { get; set; }
        public string Descr { get; set; }
        public long LocId { get; set; }
        public string RcvNumber { get; set; }
        public string ServPro { get; set; }
        public string InvNumber { get; set; }
        public string Currency { get; set; }
        public double? FxRate { get; set; }
        public double? VendCurrencyPrice { get; set; }
        public double? CustUnitPrice { get; set; }
        public double? CustTotalPrice { get; set; }
        public double? VendUnitPrice { get; set; }
        public double? VendTotalPrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ImsRcvTxnHeader Rtheader { get; set; }
    }
}
