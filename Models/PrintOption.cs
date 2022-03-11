using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class PrintOption
    {
        public string OptionType { get; set; }
        public string OptionValue { get; set; }
        public string OptionUrl { get; set; }
        public int? OptionSortOrder { get; set; }
        public string OptionDefaultValue { get; set; }
        public string OptionDesc { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
