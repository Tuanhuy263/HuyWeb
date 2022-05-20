namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProductActivityLineItem
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(250)]
        public string ActivityType { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(250)]
        public string UOM { get; set; }

        public DateTime? ItemReportingDate { get; set; }

        [StringLength(250)]
        public string StoreRegionNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitCostPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SpecialItemPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetItemPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [StringLength(250)]
        public string StoreUOM { get; set; }

        [StringLength(80)]
        public string StoreNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? StoreQuantity { get; set; }

        [StringLength(20)]
        public string ItemReportDateQualifier { get; set; }

        public int? ProductActivityDetail { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(250)]
        public string StoreName { get; set; }

        [StringLength(250)]
        public string StoreAddress1 { get; set; }

        [StringLength(250)]
        public string StoreAddress2 { get; set; }

        [StringLength(250)]
        public string StoreCity { get; set; }

        [StringLength(250)]
        public string StoreState { get; set; }

        [StringLength(250)]
        public string StoreZipCode { get; set; }

        public int? QuantityQualifier { get; set; }

        [StringLength(250)]
        public string ActivityTypeName { get; set; }

        public virtual DIO_ProductActivityDetail DIO_ProductActivityDetail { get; set; }
    }
}
