namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReturnReceipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReturnReceipt()
        {
            DIO_ReturnReceiptDetail = new HashSet<DIO_ReturnReceiptDetail>();
        }

        [Key]
        public int ReturnReceiptNo { get; set; }

        public int WHStockInNo { get; set; }

        public int? ShipFromCode { get; set; }

        public int? ShipToCode { get; set; }

        [StringLength(20)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_WHStockIn DIO_WHStockIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReturnReceiptDetail> DIO_ReturnReceiptDetail { get; set; }
    }
}
