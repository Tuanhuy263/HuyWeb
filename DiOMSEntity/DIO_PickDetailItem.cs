namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickDetailItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PickDetailItem()
        {
            DIO_PickDetailItemBatch = new HashSet<DIO_PickDetailItemBatch>();
            DIO_PickDetailItemSerial = new HashSet<DIO_PickDetailItemSerial>();
        }

        [Key]
        public int PickDetailNo { get; set; }

        public int PickNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? PickQty { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? FromLocationID { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? PickedUserID { get; set; }

        public int? ToLocationID { get; set; }

        public int? PickDetailBarcodeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackingQty { get; set; }

        public bool? IsCartonUnpack { get; set; }

        public virtual DIO_PickDetailBarcode DIO_PickDetailBarcode { get; set; }

        public virtual DIS_User DIS_User { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItemBatch> DIO_PickDetailItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItemSerial> DIO_PickDetailItemSerial { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        public virtual DIO_PickHeader DIO_PickHeader { get; set; }
    }
}
