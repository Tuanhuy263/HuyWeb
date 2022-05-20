namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ACKCompareInfors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ACKCompareInfors()
        {
            DIO_ACKSODetail = new HashSet<DIO_ACKSODetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ConditionID { get; set; }

        public int? ConditionType { get; set; }

        [StringLength(200)]
        public string Condition { get; set; }

        [StringLength(200)]
        public string ConfirmQuantity { get; set; }

        [StringLength(100)]
        public string LineItemStatus { get; set; }

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? ParaACKCompareID { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_ParaACKCompare DIO_ParaACKCompare { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSODetail> DIO_ACKSODetail { get; set; }
    }
}
