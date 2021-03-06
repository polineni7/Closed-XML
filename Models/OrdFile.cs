using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdFile
    {
        public string FileId { get; set; }
        public string OrdDivId { get; set; }
        public string Descr { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileStatus { get; set; }
        public DateTime? UploadDate { get; set; }
        public string ChgEmId { get; set; }
        public DateTime ChgLog { get; set; }
        public string ChgType { get; set; }
    }
}
