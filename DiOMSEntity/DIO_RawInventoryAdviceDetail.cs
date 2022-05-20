namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawInventoryAdviceDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawInventoryAdviceDetailID { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(48)]
        public string ProductCode1 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(48)]
        public string ProductCode2 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(48)]
        public string ProductCode3 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(48)]
        public string ProductCode4 { get; set; }

        [StringLength(3)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(48)]
        public string ProductCode5 { get; set; }

        [StringLength(20)]
        public string ClassTradeCode { get; set; }

        [StringLength(20)]
        public string PriceCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [StringLength(20)]
        public string DiscountMultiplier { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendedLineAmt { get; set; }

        [StringLength(255)]
        public string ItemDescription { get; set; }

        [StringLength(255)]
        public string ColorDescription { get; set; }

        [StringLength(255)]
        public string SizeDescription { get; set; }

        [StringLength(255)]
        public string QuantityQualifier { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        [StringLength(50)]
        public string UOM1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(50)]
        public string UOM2 { get; set; }

        [StringLength(50)]
        public string DateTimeQualifier1 { get; set; }

        [StringLength(50)]
        public string DateTimeQualifier2 { get; set; }

        [StringLength(50)]
        public string DateTimeQualifier3 { get; set; }

        public DateTime? Date1 { get; set; }

        public DateTime? Date2 { get; set; }

        public DateTime? Date3 { get; set; }

        [StringLength(10)]
        public string Time { get; set; }

        [StringLength(50)]
        public string MasterLocationCode { get; set; }

        public int? RawInventoryAdviceID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string DateTimeQualifier { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(100)]
        public string Warehouse { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdjustedQty { get; set; }

        [StringLength(50)]
        public string AdjustedUOM { get; set; }

        [StringLength(50)]
        public string ProductType { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedQty { get; set; }

        [StringLength(50)]
        public string InventoryStatus { get; set; }

        [StringLength(100)]
        public string FutureUse { get; set; }

        [StringLength(100)]
        public string DiscountinuedStatus { get; set; }

        public bool? IsValid { get; set; }

        [StringLength(48)]
        public string PONumber { get; set; }

        [StringLength(100)]
        public string LotNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [StringLength(100)]
        public string LPN { get; set; }

        [StringLength(100)]
        public string Owner { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public virtual DIO_RawInventoryAdviceHeader DIO_RawInventoryAdviceHeader { get; set; }
    }
}
