using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsLocationType
    {
        public ImsLocationType()
        {
            ImsLocationDetails = new HashSet<ImsLocationDetail>();
            ImsLocations = new HashSet<ImsLocation>();
        }

        public long LocTypeId { get; set; }
        public string LocTypeCode { get; set; }
        public string LocTypeName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? HasOnHand { get; set; }
        public bool? HasReceiver { get; set; }
        public string GroupName { get; set; }
        public bool? DisplayPacklist { get; set; }
        public string Description { get; set; }
        public string ItemType { get; set; }

        public virtual ICollection<ImsLocationDetail> ImsLocationDetails { get; set; }
        public virtual ICollection<ImsLocation> ImsLocations { get; set; }
    }
}
