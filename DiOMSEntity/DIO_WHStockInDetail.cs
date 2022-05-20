namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHStockInDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHStockInDetail()
        {
            DIO_StockInBatch = new HashSet<DIO_StockInBatch>();
            DIO_StockInSerial = new HashSet<DIO_StockInSerial>();
        }

        [Key]
        public int WHStockInDetailNo { get; set; }

        public int WHStockInNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? ReturnQuantity { get; set; }

        public int? TaxID { get; set; }

        public decimal? TaxRate { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? CustomsAmount { get; set; }

        public decimal? ExpenditureAmount { get; set; }

        public decimal? DistributedAmount { get; set; }

        public decimal? WarehouseCost { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? DiscountID { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? DiscountRate { get; set; }

        public int? MasterLocationID { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? PurchaseOrderDetailID { get; set; }

        [StringLength(100)]
        public string ReceivingConditionCode { get; set; }

        [StringLength(100)]
        public string DamageReasonCode { get; set; }

        [StringLength(100)]
        public string LotNumber { get; set; }

        [StringLength(100)]
        public string LicenseNumber { get; set; }

        public DateTime? ExpiredDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? STTotalWeight { get; set; }

        [StringLength(100)]
        public string STWeightUOMCode { get; set; }

        [StringLength(300)]
        public string Note { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        [StringLength(100)]
        public string SealNo { get; set; }

        [StringLength(250)]
        public string PedigreeNumber { get; set; }

        public int? SalesOrderDetailID { get; set; }

        public int? DocMasterItemID { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInBatch> DIO_StockInBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockInSerial> DIO_StockInSerial { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIO_WHStockIn DIO_WHStockIn { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem1 { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }
    }
}
