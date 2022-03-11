using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class CustSession
    {
        public CustSession()
        {
            SessionLogs = new HashSet<SessionLog>();
        }

        public int CustSessionId { get; set; }
        public string CmpId { get; set; }
        public string SessionId { get; set; }
        public string BuyerCookie { get; set; }
        public string BrowserFormPostUrl { get; set; }
        public string BuyerIdentity { get; set; }
        public DateTime? SessionExpiry { get; set; }
        public string OrdDivId { get; set; }
        public string PoXml { get; set; }

        public virtual Customer Cmp { get; set; }
        public virtual ICollection<SessionLog> SessionLogs { get; set; }
    }
}
