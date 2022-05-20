namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OrderStatusReport870Detail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int OrderStatusDetailID { get; set; }

        [StringLength(100)]
        public string OrderStatus { get; set; }

        [StringLength(100)]
        public string QtyType { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyShippedCanceled { get; set; }

        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(100)]
        public string ContactPhone { get; set; }

        [StringLength(100)]
        public string ReferenceType { get; set; }

        [StringLength(100)]
        public string ReferenceID { get; set; }

        public int? LnNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [StringLength(255)]
        public string ItemDescriptionCode { get; set; }

        [StringLength(100)]
        public string QuantityQualifier { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? ItemStatus { get; set; }

        public DateTime? ItemStatusDate { get; set; }

        [StringLength(100)]
        public string EntityIDCode { get; set; }

        [StringLength(100)]
        public string EntityIDName { get; set; }

        [StringLength(100)]
        public string IDCodeQualifier { get; set; }

        [StringLength(100)]
        public string IDCode { get; set; }

        [StringLength(100)]
        public string Routing { get; set; }

        [StringLength(100)]
        public string RefQualifier { get; set; }

        [StringLength(100)]
        public string RefID { get; set; }

        [StringLength(100)]
        public string ProductCode1 { get; set; }

        [StringLength(100)]
        public string ProductCode2 { get; set; }

        [StringLength(100)]
        public string ProductCode3 { get; set; }

        [StringLength(100)]
        public string ProductCode4 { get; set; }

        [StringLength(100)]
        public string ProductCode5 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier5 { get; set; }

        public int? MasterItemID { get; set; }

        public int? UOMID { get; set; }

        public int? ProviderID { get; set; }

        public int? OrderStatusID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ProductCode6 { get; set; }

        [StringLength(100)]
        public string ProductCode7 { get; set; }

        [StringLength(100)]
        public string ProductCode8 { get; set; }

        [StringLength(100)]
        public string ProductCode9 { get; set; }

        [StringLength(100)]
        public string ProductCode10 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? NoOfInnerPack { get; set; }

        [StringLength(100)]
        public string TrackingNumber { get; set; }

        [StringLength(100)]
        public string BOLNumber { get; set; }

        [StringLength(100)]
        public string LoadNumber { get; set; }

        [StringLength(255)]
        public string ItemDescription { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIO_OrderStatusReport870Header DIO_OrderStatusReport870Header { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
