namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutomationFlow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AutomationFlow()
        {
            DIO_AutomationFlowDetail = new HashSet<DIO_AutomationFlowDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int FlowID { get; set; }

        [StringLength(200)]
        public string FlowName { get; set; }

        public int? ScheduleID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool? AutoRun { get; set; }

        public virtual DIO_AutomationSchedule DIO_AutomationSchedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutomationFlowDetail> DIO_AutomationFlowDetail { get; set; }
    }
}
