namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHOrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHOrderDetail()
        {
            DIO_SelectItemOTS_FIFO = new HashSet<DIO_SelectItemOTS_FIFO>();
            DIO_WHOrderDetailBatch = new HashSet<DIO_WHOrderDetailBatch>();
            DIO_WHOrderDetailSerial = new HashSet<DIO_WHOrderDetailSerial>();
        }

        [Key]
        public int WhOrderDetailNo { get; set; }

        public int WHOrderNo { get; set; }

        public int? MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? StockOutQty { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public decimal? PackedToShipQty { get; set; }

        public int? MasterLocationID { get; set; }

        public decimal? TempPackedToShipQty { get; set; }

        public int? SaleOrderDetailID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SelectItemOTS_FIFO> DIO_SelectItemOTS_FIFO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderDetailBatch> DIO_WHOrderDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderDetailSerial> DIO_WHOrderDetailSerial { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_WHOrderHeader DIO_WHOrderHeader { get; set; }
    }
}
