namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_ActionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_ActionType()
        {
            DIS_Action = new HashSet<DIS_Action>();
            DIS_ActionTypeAttribute = new HashSet<DIS_ActionTypeAttribute>();
            DIS_ActionTypeParameter = new HashSet<DIS_ActionTypeParameter>();
        }

        [Key]
        public int ActionTypeID { get; set; }

        [Required]
        [StringLength(200)]
        public string ActionTypeCode { get; set; }

        [Required]
        [StringLength(400)]
        public string ActionTypeName { get; set; }

        public bool IsReport { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Action> DIS_Action { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ActionTypeAttribute> DIS_ActionTypeAttribute { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ActionTypeParameter> DIS_ActionTypeParameter { get; set; }
    }
}
