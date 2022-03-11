using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsLocationDetail
    {
        public long Ldid { get; set; }
        public long LocId { get; set; }
        public long LocTypeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ImsLocation Loc { get; set; }
        public virtual ImsLocationType LocType { get; set; }
    }
}
