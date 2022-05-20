namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutomationFlowKeepTrack
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AutomationFlowKeepTrackID { get; set; }

        [StringLength(100)]
        public string Action { get; set; }

        [StringLength(200)]
        public string WorkFlow { get; set; }

        public int? Activity { get; set; }

        [StringLength(200)]
        public string FieldName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        public DateTime? DateChange { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
