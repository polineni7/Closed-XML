using System;
using System.Collections.Generic;

#nullable disable

namespace CloseXML.Models
{
    public partial class OrdShip
    {
        public string OrdShipId { get; set; }
        public string OrdDivId { get; set; }
        public int? ShipId { get; set; }
        public string SiteUrl { get; set; }
        public DateTime? ShipDate { get; set; }
        public DateTime? Etadate { get; set; }
        public string TrackNum { get; set; }
        public string ChgEmId { get; set; }
        public DateTime? ChgLog { get; set; }
        public string ChgType { get; set; }
        public DateTime? LastRemind { get; set; }
        public string FdMasterAwb { get; set; }
        public string FdFlightNo { get; set; }
        public string FdDestination { get; set; }
        public string FdPieces { get; set; }
        public string FdDescription { get; set; }
        public string FdMasterGen { get; set; }
        public string FdNotes { get; set; }
        public string FdMasterBlno { get; set; }
        public string ShipOptionId { get; set; }
        public string Consignee { get; set; }
        public string ShipperHead { get; set; }
        public DateTime? EstArDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? EstDelivDate { get; set; }
    }
}
