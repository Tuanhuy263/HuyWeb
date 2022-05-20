namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutomationStatusManagement
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AutomationFlowManagementID { get; set; }

        [StringLength(250)]
        public string MachineName { get; set; }

        [StringLength(250)]
        public string MachineAddress { get; set; }

        [StringLength(200)]
        public string Username { get; set; }

        public int? AutomationFlowID { get; set; }

        [StringLength(100)]
        public string AutomationFlowName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? StopDate { get; set; }

        public int? Status { get; set; }

        [StringLength(100)]
        public string StatusDescription { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
