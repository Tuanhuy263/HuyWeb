namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_Action
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_Action()
        {
            DIS_EventExpressionAction = new HashSet<DIS_EventExpressionAction>();
        }

        [Key]
        public int ActionID { get; set; }

        [Required]
        [StringLength(400)]
        public string ActionName { get; set; }

        [Required]
        [StringLength(128)]
        public string AssemblyName { get; set; }

        [Required]
        [StringLength(128)]
        public string TypeName { get; set; }

        [Required]
        [StringLength(128)]
        public string FunctionName { get; set; }

        public int ActionTypeID { get; set; }

        [Required]
        [StringLength(400)]
        public string ContextData { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_ActionType DIS_ActionType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_EventExpressionAction> DIS_EventExpressionAction { get; set; }
    }
}
