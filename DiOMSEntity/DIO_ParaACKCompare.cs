namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ParaACKCompare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ParaACKCompare()
        {
            DIO_ACKCompareInfors = new HashSet<DIO_ACKCompareInfors>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ParameterID { get; set; }

        public int? ItemStatusValidationType { get; set; }

        public int? ConditionType { get; set; }

        [StringLength(200)]
        public string ConditionCompare { get; set; }

        [StringLength(200)]
        public string ConfirmQuantity { get; set; }

        [StringLength(100)]
        public string DecriptionItemStatus { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKCompareInfors> DIO_ACKCompareInfors { get; set; }
    }
}
