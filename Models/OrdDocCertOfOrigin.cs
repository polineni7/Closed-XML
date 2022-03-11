using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdDocCertOfOrigin
    {
        public string OrdDivId { get; set; }
        public DateTime? DateofInvoice { get; set; }
        public string ClientPo { get; set; }
        public string DescrOfGoods { get; set; }
        public string CountryOfOrg { get; set; }
        public string CountryOfDest { get; set; }
        public string Shippedvia { get; set; }
        public string FromCustom { get; set; }
        public string ToCustom { get; set; }
        public string TermsofPayment { get; set; }
        public DateTime? DateOfCert { get; set; }
        public string SignedBy { get; set; }
        public string Buyer { get; set; }
        public string Consignee { get; set; }
        public DateTime? ShipDate { get; set; }
        public string Nb { get; set; }
        public string Certification { get; set; }
        public string Exporter { get; set; }
    }
}
