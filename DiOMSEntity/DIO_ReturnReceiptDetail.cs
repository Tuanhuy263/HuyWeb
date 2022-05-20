namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReturnReceiptDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReturnReceiptDetail()
        {
            DIO_ReturnReceiptBatch = new HashSet<DIO_ReturnReceiptBatch>();
            DIO_ReturnReceiptSerial = new HashSet<DIO_ReturnReceiptSerial>();
        }

        [Key]
        public int ReturnReceiptDetailNo { get; set; }

        public int ReturnReceiptNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? ReturnQuantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? MasterLocationID { get; set; }

        public int? PurchaseOrderDetailID { get; set; }

        public int? WHStockInDetailID { get; set; }

        public int? LnNo { get; set; }

        public virtual DIO_ReturnReceipt DIO_ReturnReceipt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceiptBatch> DIO_ReturnReceiptBatch { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceiptSerial> DIO_ReturnReceiptSerial { get; set; }
    }
}
