namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_860Detail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int Raw860DetailID { get; set; }

        [StringLength(250)]
        public string ProductCode1 { get; set; }

        [StringLength(250)]
        public string ProductCode2 { get; set; }

        [StringLength(250)]
        public string ProductCode3 { get; set; }

        [StringLength(250)]
        public string ProductCode4 { get; set; }

        [StringLength(250)]
        public string ProductCode5 { get; set; }

        [StringLength(250)]
        public string ProductCode6 { get; set; }

        [StringLength(250)]
        public string ProductCode7 { get; set; }

        [StringLength(250)]
        public string ProductCode8 { get; set; }

        [StringLength(250)]
        public string ProductCode9 { get; set; }

        [StringLength(250)]
        public string ProductCode10 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(250)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(250)]
        public string MarkForStoreNo { get; set; }

        [StringLength(250)]
        public string MarkForStoreAddress1 { get; set; }

        [StringLength(250)]
        public string MarkForStoreAddress2 { get; set; }

        [StringLength(250)]
        public string MarkForStoreCity { get; set; }

        [StringLength(250)]
        public string MarkForStoreState { get; set; }

        [StringLength(250)]
        public string MarkForStoreZipCode { get; set; }

        [StringLength(250)]
        public string MarkForStoreName { get; set; }

        [StringLength(250)]
        public string OrderUOM { get; set; }

        [StringLength(250)]
        public string LnNo { get; set; }

        [StringLength(250)]
        public string ProductDescription { get; set; }

        [StringLength(250)]
        public string ColorDescription { get; set; }

        [StringLength(250)]
        public string SizeDescription { get; set; }

        [StringLength(250)]
        public string UserDefine112 { get; set; }

        [StringLength(250)]
        public string UserDefine113 { get; set; }

        [StringLength(250)]
        public string ItemChangeType { get; set; }

        [StringLength(250)]
        public string BasisUnitPrice { get; set; }

        [StringLength(250)]
        public string ModifyUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? POQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvailableToShip { get; set; }

        [Column(TypeName = "money")]
        public decimal? GroceryPack { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? NoOfInnerPack { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyLeftToShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalOrderAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedLineAmount { get; set; }

        public int? NumberOfLine { get; set; }

        [Column("860HeaderID")]
        public int? C860HeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_860Header DIO_860Header { get; set; }
    }
}
