namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackDetailCarton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackDetailCarton()
        {
            DIO_PackDetailItem = new HashSet<DIO_PackDetailItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PackDetailCartonID { get; set; }

        [StringLength(100)]
        public string Barcode { get; set; }

        public int? PackDetailID { get; set; }

        public int? InventoryCartonID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ASNCartonCode { get; set; }

        public int? PickDetailBarcodeID { get; set; }

        public int? PackDetailPalletID { get; set; }

        public virtual DIO_InventoryCarton DIO_InventoryCarton { get; set; }

        public virtual DIO_PackDetail DIO_PackDetail { get; set; }

        public virtual DIO_PackDetailPallet DIO_PackDetailPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailItem> DIO_PackDetailItem { get; set; }
    }
}
