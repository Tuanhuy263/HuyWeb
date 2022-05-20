namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawPODetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawPODetailId { get; set; }

        [StringLength(48)]
        public string ProductCode1 { get; set; }

        [StringLength(48)]
        public string ProductCode2 { get; set; }

        [StringLength(48)]
        public string ProductCode3 { get; set; }

        [StringLength(48)]
        public string ProductCode4 { get; set; }

        [StringLength(48)]
        public string ProductCode5 { get; set; }

        [StringLength(48)]
        public string ProductCode6 { get; set; }

        [StringLength(48)]
        public string ProductCode7 { get; set; }

        [StringLength(48)]
        public string ProductCode8 { get; set; }

        [StringLength(48)]
        public string ProductCode9 { get; set; }

        [StringLength(48)]
        public string ProductCode10 { get; set; }

        public int? LnNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        [StringLength(10)]
        public string UnitOfMeasure { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [StringLength(2)]
        public string BasisUnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? RetailPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? MultPriceQty { get; set; }

        [StringLength(250)]
        public string ProductDescription { get; set; }

        [StringLength(50)]
        public string ColorDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? Size { get; set; }

        [StringLength(255)]
        public string SizeDescription { get; set; }

        [StringLength(20)]
        public string MarkForStoreNo { get; set; }

        [StringLength(250)]
        public string MarkForAddress1 { get; set; }

        [StringLength(250)]
        public string MarkForAddress2 { get; set; }

        [StringLength(50)]
        public string MarkForCity { get; set; }

        [StringLength(20)]
        public string MarkForState { get; set; }

        [StringLength(20)]
        public string MarkForZipCode { get; set; }

        [StringLength(250)]
        public string MarkForStoreName { get; set; }

        [StringLength(30)]
        public string BuyerCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [StringLength(30)]
        public string TicketCode { get; set; }

        [StringLength(250)]
        public string ShipToFacility { get; set; }

        [StringLength(250)]
        public string FutureUse114 { get; set; }

        [Column(TypeName = "money")]
        public decimal? NoOfInnerPacks { get; set; }

        [StringLength(50)]
        public string ItemChangeType { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyLeftToShipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyUnitOfMeasure { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedLineAmount { get; set; }

        [StringLength(3)]
        public string ProductCode1Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode2Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode3Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode4Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode5Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode6Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode7Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode8Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode9Qualifier { get; set; }

        [StringLength(3)]
        public string ProductCode10Qualifier { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator1 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent1 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling1 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator2 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent2 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling2 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator3 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent3 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling3 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeIndicator4 { get; set; }

        [StringLength(20)]
        public string LineAllowanceOrChargeCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargeAmount4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineAllowanceOrChargePercent4 { get; set; }

        [StringLength(20)]
        public string LineAllowanceMethodOfHandling4 { get; set; }

        [StringLength(20)]
        public string FutureUse184 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemGroceryAllowanceRate1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemGroceryAllowanceRate2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemGroceryAllowanceRate3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemGroceryAllowanceRate4 { get; set; }

        [StringLength(250)]
        public string FutureUse189 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemQuantity1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemQuantity2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemQuantity3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemQuantity4 { get; set; }

        [StringLength(30)]
        public string InvoiceGTSTaxID { get; set; }

        [Column(TypeName = "money")]
        public decimal? GSTAmount { get; set; }

        [StringLength(30)]
        public string HSTSalesTaxID { get; set; }

        [Column(TypeName = "money")]
        public decimal? HSTSalesTaxAmount { get; set; }

        public int? MasterItemID { get; set; }

        public int? RawPOHeaderId { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string UserDefined113 { get; set; }

        public virtual DIO_RawPOHeader DIO_RawPOHeader { get; set; }
    }
}
