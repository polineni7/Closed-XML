using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class AdmServiceContractsServiceCategory
    {
        public AdmServiceContractsServiceCategory()
        {
            AdmServiceContracts = new HashSet<AdmServiceContract>();
            AdmServiceContractsClientDescriptions = new HashSet<AdmServiceContractsClientDescription>();
        }

        public int ServiceCategoryId { get; set; }
        public string ServiceCategoryName { get; set; }

        public virtual ICollection<AdmServiceContract> AdmServiceContracts { get; set; }
        public virtual ICollection<AdmServiceContractsClientDescription> AdmServiceContractsClientDescriptions { get; set; }
    }
}
