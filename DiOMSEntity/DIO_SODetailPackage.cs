namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SODetailPackage
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(150)]
        public string PackageNumber { get; set; }

        [StringLength(50)]
        public string TrackingNo { get; set; }

        public byte[] Label { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        public int? WeightUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? SequenceNumber { get; set; }

        public int? SODetailNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(500)]
        public string UPS_Status_Type_Description { get; set; }

        public byte? UPS_Status_Type { get; set; }

        public byte? UPS_Status_Type_Code { get; set; }

        [StringLength(255)]
        public string ShipmentIDByCarrier { get; set; }

        [StringLength(20)]
        public string TrackingStatusCode { get; set; }

        [StringLength(500)]
        public string TrackingStatusDescription { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
