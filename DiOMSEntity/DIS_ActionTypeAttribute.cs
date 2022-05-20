namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_ActionTypeAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_ActionTypeAttribute()
        {
            DIS_EventActionAttribute = new HashSet<DIS_EventActionAttribute>();
        }

        [Key]
        public int AttributeID { get; set; }

        [Required]
        [StringLength(200)]
        public string AttributeCode { get; set; }

        [Required]
        [StringLength(400)]
        public string AttributeName { get; set; }

        [Required]
        [StringLength(128)]
        public string DataType { get; set; }

        public int? MaxLength { get; set; }

        public int ActionTypeID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? AllowNull { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_ActionType DIS_ActionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_EventActionAttribute> DIS_EventActionAttribute { get; set; }
    }
}
