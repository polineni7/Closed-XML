using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdLineSub
    {
        public long LineSubId { get; set; }
        public string OrdLineId { get; set; }
        public int? QtyReceived { get; set; }
        public DateTime? Date { get; set; }
        public string IparecNum { get; set; }
        public string ServiceProviderNum { get; set; }
        public string DispatchLoc { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime? SubmittedToAccounting { get; set; }
        public double? VendServiceCost { get; set; }
        public double? UnitValue { get; set; }
        public double? TotalValue { get; set; }
        public long? LocId { get; set; }
        public long? RtheaderId { get; set; }
        public long? OnHandLocId { get; set; }
        public string OnHandType { get; set; }
        public string CmpId { get; set; }
        public string NcReason { get; set; }
        public int? NcResolve { get; set; }
        public string NcDescr { get; set; }
        public int? NonAllocInv { get; set; }
        public int? TicketSeq { get; set; }
        public DateTime? SerialNumAllocDate { get; set; }
        public bool? PickedFlag { get; set; }
        public DateTime? PickedDate { get; set; }
        public string PickedBy { get; set; }
        public bool? TransferFlag { get; set; }
        public double? LabelLineQty { get; set; }
        public long? AllocateId { get; set; }
        public string SublineStatus { get; set; }
        public int? QtyResolved { get; set; }
        public string FromOnHandOc { get; set; }
        public string Notes { get; set; }

        public virtual OrdLine OrdLine { get; set; }
    }
}
