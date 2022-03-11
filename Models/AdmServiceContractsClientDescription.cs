using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class AdmServiceContractsClientDescription
    {
        public AdmServiceContractsClientDescription()
        {
            AdmServiceContracts = new HashSet<AdmServiceContract>();
        }

        public int ClientDescriptionId { get; set; }
        public string ClientDescription { get; set; }
        public int? ServiceCategoryId { get; set; }
        public double? ProfitMargin { get; set; }

        public virtual AdmServiceContractsServiceCategory ServiceCategory { get; set; }
        public virtual ICollection<AdmServiceContract> AdmServiceContracts { get; set; }
    }
}
