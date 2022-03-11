using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdReply
    {
        public string OrdReplyId { get; set; }
        public string OrdId { get; set; }
        public DateTime? DateSubmit { get; set; }
        public string CompanyPo { get; set; }
        public string Message { get; set; }
        public string ReplyType { get; set; }
        public short? Control { get; set; }
        public string CorrespondenceTopic { get; set; }
        public string Partial { get; set; }
        public string Version { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
    }
}
