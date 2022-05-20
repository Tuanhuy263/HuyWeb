namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_MasterEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_MasterEvent()
        {
            DIO_MasterEventSO = new HashSet<DIO_MasterEventSO>();
            DIO_PickingList = new HashSet<DIO_PickingList>();
        }

        [Key]
        public int MasterEventNo { get; set; }

        [Required]
        [StringLength(255)]
        public string MasterEventNumber { get; set; }

        public DateTime EventDate { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? PrintWarehousePackList { get; set; }

        public long? METraceStatus { get; set; }

        public int? FlagID { get; set; }

        [StringLength(255)]
        public string InternalVendorNumber { get; set; }

        public DateTime? MustShipDate { get; set; }

        public int? MasterItemID { get; set; }

        public virtual DIO_Flag DIO_Flag { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterEventSO> DIO_MasterEventSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingList> DIO_PickingList { get; set; }
    }
}
