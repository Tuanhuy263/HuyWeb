namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_EventActionAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_EventActionAttribute()
        {
            DIS_EventActionAttributeUser = new HashSet<DIS_EventActionAttributeUser>();
        }

        [Key]
        public int EventActionAttributeID { get; set; }

        public int EventActionID { get; set; }

        public int AttributeID { get; set; }

        [Required]
        [StringLength(4000)]
        public string UserValue { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_ActionTypeAttribute DIS_ActionTypeAttribute { get; set; }

        public virtual DIS_EventExpressionAction DIS_EventExpressionAction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_EventActionAttributeUser> DIS_EventActionAttributeUser { get; set; }
    }
}
