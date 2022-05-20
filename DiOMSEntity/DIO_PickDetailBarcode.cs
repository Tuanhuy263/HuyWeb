namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickDetailBarcode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PickDetailBarcode()
        {
            DIO_PickDetailCarton = new HashSet<DIO_PickDetailCarton>();
            DIO_PickDetailItem = new HashSet<DIO_PickDetailItem>();
            DIO_PickDetailPallet = new HashSet<DIO_PickDetailPallet>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PickDetailBarcodeID { get; set; }

        [StringLength(100)]
        public string Barcode { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        public int? PickHeaderID { get; set; }

        public int? LocationID { get; set; }

        public int? PrintTemplateID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? PickProgressID { get; set; }

        public bool? IsPacked { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_PickHeader DIO_PickHeader { get; set; }

        public virtual DIO_PickingProgress DIO_PickingProgress { get; set; }

        public virtual DIO_PrintTemplate DIO_PrintTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailCarton> DIO_PickDetailCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItem> DIO_PickDetailItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailPallet> DIO_PickDetailPallet { get; set; }
    }
}
