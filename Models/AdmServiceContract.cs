using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class AdmServiceContract
    {
        public int ContactId { get; set; }
        public string ServiceContractMame { get; set; }
        public int? ServiceCategoryId { get; set; }
        public int? ClientDescriptionId { get; set; }
        public string DefaultServiceProvider { get; set; }
        public double? DefaultMargin { get; set; }

        public virtual AdmServiceContractsClientDescription ClientDescription { get; set; }
        public virtual AdmServiceContractsServiceCategory ServiceCategory { get; set; }
    }
}
