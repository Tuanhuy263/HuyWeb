namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_Event()
        {
            DIS_EventExpression = new HashSet<DIS_EventExpression>();
        }

        [Key]
        public int EventID { get; set; }

        [Required]
        [StringLength(400)]
        public string EventCode { get; set; }

        [Required]
        [StringLength(400)]
        public string EventName { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public int EventTypeID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_EventType DIS_EventType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_EventExpression> DIS_EventExpression { get; set; }
    }
}
