using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class SessionLog
    {
        public int SessionLogId { get; set; }
        public string SessionId { get; set; }
        public string RequestXml { get; set; }
        public string ResponseXml { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string TransactionType { get; set; }
        public string CmpId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public virtual CustSession Session { get; set; }
    }
}
