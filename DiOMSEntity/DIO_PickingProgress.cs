namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickingProgress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PickingProgress()
        {
            DIO_PickDetailBarcode = new HashSet<DIO_PickDetailBarcode>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PickingProgressNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? PickHeaderNo { get; set; }

        public int? UserID { get; set; }

        public bool? IsActived { get; set; }

        public DateTime? PickedTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailBarcode> DIO_PickDetailBarcode { get; set; }

        public virtual DIO_PickHeader DIO_PickHeader { get; set; }

        public virtual DIS_User DIS_User { get; set; }
    }
}
