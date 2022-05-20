namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawRoutingInstructionDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RoutingInstructionDetailID { get; set; }

        public int? LineNo { get; set; }

        [StringLength(3)]
        public string RefType { get; set; }

        [StringLength(80)]
        public string ShipmentInfo { get; set; }

        [StringLength(22)]
        public string SONo { get; set; }

        public DateTime? RequestedShipDate { get; set; }

        public DateTime? ScheduledPickupDate { get; set; }

        [StringLength(8)]
        public string SheduledPickupTime { get; set; }

        [StringLength(2)]
        public string TimeCodeDetail { get; set; }

        [Column(TypeName = "money")]
        public decimal? ScheduledQty { get; set; }

        [StringLength(30)]
        public string ShipmentUnit { get; set; }

        [StringLength(255)]
        public string ShipToCode { get; set; }

        [StringLength(255)]
        public string ShipToCodeQualifier { get; set; }

        [StringLength(255)]
        public string ShipToName { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(255)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToCity { get; set; }

        [StringLength(255)]
        public string ShipToState { get; set; }

        [StringLength(255)]
        public string ShipToZipcode { get; set; }

        [StringLength(255)]
        public string ShipToCountry { get; set; }

        [StringLength(255)]
        public string ShipToLocationQualifier { get; set; }

        [StringLength(255)]
        public string ShipToLocationCode { get; set; }

        [StringLength(2)]
        public string WeightQualifier { get; set; }

        [StringLength(20)]
        public string WeightUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [StringLength(20)]
        public string VolumeUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        public int? RoutingInstructionHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_RawRoutingInstructionHeader DIO_RawRoutingInstructionHeader { get; set; }
    }
}
