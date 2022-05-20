namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHStockOutDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHStockOutDetail()
        {
            DIO_StockOutBatch = new HashSet<DIO_StockOutBatch>();
            DIO_StockOutSerial = new HashSet<DIO_StockOutSerial>();
        }

        [Key]
        public int WHStockOutDetailNo { get; set; }

        public int WHStockOutNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? ReturnQuantity { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? MasterLocationID { get; set; }

        public int ShipmentUnitOfMeasure { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        public int? SaleOrderDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedValue { get; set; }

        [Column(TypeName = "money")]
        public decimal? TempReturnedQty { get; set; }

        [StringLength(100)]
        public string ContainerNo { get; set; }

        [StringLength(250)]
        public string PedigreeNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockOutBatch> DIO_StockOutBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_StockOutSerial> DIO_StockOutSerial { get; set; }

        public virtual DIO_WHStockOut DIO_WHStockOut { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }
    }
}
