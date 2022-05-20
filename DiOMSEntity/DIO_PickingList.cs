namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickingList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PickingList()
        {
            DIO_PickHeader = new HashSet<DIO_PickHeader>();
            DIO_PickingListDetail = new HashSet<DIO_PickingListDetail>();
        }

        [Key]
        public int PickingListNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public int? MasterEventNo { get; set; }

        public int? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? PrintPickingList { get; set; }

        public int? Hub { get; set; }

        public bool? IsPacking { get; set; }

        public virtual DIO_MasterEvent DIO_MasterEvent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickHeader> DIO_PickHeader { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingListDetail> DIO_PickingListDetail { get; set; }
    }
}
