namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutomationFlowDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int FlowDetailID { get; set; }

        public string Config { get; set; }

        public int? TaskType { get; set; }

        public int? FlowID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? Order { get; set; }

        public virtual DIO_AutomationFlow DIO_AutomationFlow { get; set; }
    }
}
