using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsCustRcvFile
    {
        public long FileId { get; set; }
        public long? RtheaderId { get; set; }
        public string TicketId { get; set; }
        public string Descr { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
