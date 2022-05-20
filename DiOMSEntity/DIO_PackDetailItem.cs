namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackDetailItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackDetailItem()
        {
            DIO_PackDetailItemBatch = new HashSet<DIO_PackDetailItemBatch>();
            DIO_PackDetailItemSerial = new HashSet<DIO_PackDetailItemSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PackDetailItemID { get; set; }

        [StringLength(100)]
        public string Barcode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? PackDetailID { get; set; }

        public int? PackDetailCartonID { get; set; }

        public int? MasterItemID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ASNCartonCode { get; set; }

        public int? PickDetailBarcodeID { get; set; }

        public virtual DIO_PackDetail DIO_PackDetail { get; set; }

        public virtual DIO_PackDetailCarton DIO_PackDetailCarton { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailItemBatch> DIO_PackDetailItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailItemSerial> DIO_PackDetailItemSerial { get; set; }
    }
}
