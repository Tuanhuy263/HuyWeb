namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RoutingRequestDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RoutingRequestDetailId { get; set; }

        public int? LineNo { get; set; }

        [StringLength(80)]
        public string ShipToCode { get; set; }

        [StringLength(250)]
        public string ShipToName { get; set; }

        [StringLength(2)]
        public string ShipToCodeQualifier { get; set; }

        [StringLength(200)]
        public string ShipToAddress1 { get; set; }

        [StringLength(200)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToCity { get; set; }

        [StringLength(255)]
        public string ShipToState { get; set; }

        [StringLength(255)]
        public string ShipToZipcode { get; set; }

        [StringLength(255)]
        public string ShipToCountry { get; set; }

        [StringLength(50)]
        public string BolNumber { get; set; }

        [StringLength(80)]
        public string NonStandardPallet { get; set; }

        public DateTime? EarliestPickupDate { get; set; }

        [StringLength(4)]
        public string EarliestPickupTime { get; set; }

        [StringLength(2)]
        public string TimeCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(5)]
        public string PackingCode { get; set; }

        [StringLength(255)]
        public string PackingTypeName { get; set; }

        [StringLength(1)]
        public string Stackable { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [StringLength(30)]
        public string CommodityCode { get; set; }

        [StringLength(5)]
        public string NmfClassificationCode { get; set; }

        [StringLength(22)]
        public string SoNo { get; set; }

        public int? RoutingRequestHeaderId { get; set; }

        public int? WeightUOM { get; set; }

        public int? VolumeUOM { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? Ext_Quantity { get; set; }

        [StringLength(50)]
        public string Ext_PackingTypeName { get; set; }

        public virtual DIO_RoutingRequestHeader DIO_RoutingRequestHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }
    }
}
