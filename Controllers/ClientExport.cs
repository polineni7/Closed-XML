using System;

namespace CloseXML.Controllers
{
    public class ClientExport
    {
        public string CompanyPO { get; set; }
        public string OrdID { get; set; }
        public string OrdName { get; set; }
        public string ProgramID { get; set; }
        public string OrdDivID { get; set; }
        public DateTime? ReqDate { get; set; }
        public DateTime? InqDate { get; set; }
        public string StatusOR { get; set; }
        public string Status { get; set; }
        public string Descr { get; set; }
        public string Client { get; set; }
        public string Incoterms { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationInfo { get; set; }
        public string PaymentTerms { get; set; }
        public decimal? OrdTotal { get; set; }
        public decimal? OrdExTotal { get; set; }
        public decimal? OrdFxTotal { get; set; }
        public DateTime? QuoteDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? estShipDate { get; set; }
        public DateTime? ArrvDate { get; set; }
        public DateTime? estArrvDate { get; set; }
        public DateTime? InvDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public DateTime? DelivDate { get; set; }
        public DateTime? estDelivDate { get; set; }
        public DateTime? Processed { get; set; }
        public DateTime? Dispatched { get; set; }
        public DateTime? Fulfilled { get; set; }
        public DateTime? Packed { get; set; }
        public DateTime? QtdShipDate { get; set; }
        public DateTime? QtdArrDate { get; set; }
        public DateTime? PromisDelivDate { get; set; }
        public DateTime? Picked { get; set; }
        public DateTime? Confirmed { get; set; }
        public DateTime? Consolidated { get; set; }
    }

    public class ClientLoginSearch
    {
        public string OrdID { get; set; }
        public string CmpID { get; set; }
        public string ProgramID { get; set; }
        public string PO { get; set; }
        public string[] Status { get; set; }
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public string Descr { get; set; }


    }
}