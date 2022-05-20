namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryAdviceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryAdviceDetail()
        {
            DIO_InventoryAdviceLocation = new HashSet<DIO_InventoryAdviceLocation>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int InventoryAdviceDetailID { get; set; }

        public int? NumberOfLineItems { get; set; }

        [Column(TypeName = "money")]
        public decimal? HashTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [StringLength(15)]
        public string WeightUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? Volume { get; set; }

        [StringLength(15)]
        public string VolumeUOM { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

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

        [StringLength(500)]
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
        public string UOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(50)]
        public string DateTimeQualifier { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(10)]
        public string Time { get; set; }

        [Column(TypeName = "money")]
        public decimal? Backordered { get; set; }

        [Column(TypeName = "money")]
        public decimal? OnOrder { get; set; }

        [Column(TypeName = "money")]
        public decimal? NextAvailability { get; set; }

        public DateTime? NextAvailabilityDate { get; set; }

        public int? InventoryAdviceID { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? UOMID { get; set; }

        public int? OptimisticLockField { get; set; }

        public DateTime? Date1 { get; set; }

        public DateTime? Date2 { get; set; }

        public DateTime? Date3 { get; set; }

        [StringLength(50)]
        public string DateTimeQualifier1 { get; set; }

        [StringLength(50)]
        public string DateTimeQualifier2 { get; set; }

        [StringLength(50)]
        public string DateTimeQualifier3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedQty { get; set; }

        public DateTime? MaximumAvailabilityDate { get; set; }

        public int? MaximumAvailability { get; set; }

        public int? MinimumAvailabilityDays { get; set; }

        [StringLength(100)]
        public string Warehouse { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdjustedQty { get; set; }

        [StringLength(50)]
        public string AdjustedUOM { get; set; }

        [StringLength(50)]
        public string ProductType { get; set; }

        [StringLength(50)]
        public string InventoryStatus { get; set; }

        [StringLength(100)]
        public string FutureUse { get; set; }

        [StringLength(100)]
        public string DiscountinuedStatus { get; set; }

        public int? LeadTimeMinDays { get; set; }

        public int? LeadTimeMaxDays { get; set; }

        public int? CurrentBatchFileSequenceID { get; set; }

        public int? TotalBatchFiles { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public bool? IsUpdateInventory { get; set; }

        public DateTime? AvailableToShip { get; set; }

        [StringLength(100)]
        public string PONumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvailableToSalesQty { get; set; }

        [StringLength(100)]
        public string LotNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int? BatchID { get; set; }

        [StringLength(100)]
        public string LPN { get; set; }

        [StringLength(100)]
        public string Owner { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public virtual DIO_Batch DIO_Batch { get; set; }

        public virtual DIO_InventoryAdviceHeader DIO_InventoryAdviceHeader { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryAdviceLocation> DIO_InventoryAdviceLocation { get; set; }
    }
}
