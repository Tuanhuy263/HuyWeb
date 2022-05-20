namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickingListDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PickingListDetail()
        {
            DIO_PickingListDetailBatch = new HashSet<DIO_PickingListDetailBatch>();
            DIO_PickingListDetailSerial = new HashSet<DIO_PickingListDetailSerial>();
        }

        [Key]
        public int PickingListDetailNo { get; set; }

        public int PickingListNo { get; set; }

        public int? MasterItemID { get; set; }

        public decimal? Qty { get; set; }

        public decimal? PickedQty { get; set; }

        public int? MasterLocationID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? PickedIndividualQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackingQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackingIndividualQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackedIndividualQty { get; set; }

        public int? ToMasterLocationID { get; set; }

        public virtual DIO_PickingList DIO_PickingList { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingListDetailBatch> DIO_PickingListDetailBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingListDetailSerial> DIO_PickingListDetailSerial { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }
    }
}
