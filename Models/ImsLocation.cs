using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class ImsLocation
    {
        public ImsLocation()
        {
            ImsLocationDetails = new HashSet<ImsLocationDetail>();
            ImsPolines = new HashSet<ImsPoline>();
            ImsRcvTxns = new HashSet<ImsRcvTxn>();
        }

        public long LocId { get; set; }
        public long? LocTypeId { get; set; }
        public long? ParentId { get; set; }
        public string LocCode { get; set; }
        public string LocName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public bool? HasFca { get; set; }
        public bool? HasFob { get; set; }
        public bool? HasClient { get; set; }
        public bool? HasInv { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? NonAllocInvFlag { get; set; }
        public string Address2 { get; set; }
        public string City2 { get; set; }
        public string State2 { get; set; }
        public string Country2 { get; set; }
        public string ZipCode2 { get; set; }
        public int? DefAddressOpt { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Initial { get; set; }

        public virtual ImsLocationType LocType { get; set; }
        public virtual ICollection<ImsLocationDetail> ImsLocationDetails { get; set; }
        public virtual ICollection<ImsPoline> ImsPolines { get; set; }
        public virtual ICollection<ImsRcvTxn> ImsRcvTxns { get; set; }
    }
}
