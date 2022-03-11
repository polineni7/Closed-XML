using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ClientProgramV
    {
        public string CmpId { get; set; }
        public string ParentId { get; set; }
        public string ProgramId { get; set; }
        public string Company { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string IsProgram { get; set; }
    }
}
