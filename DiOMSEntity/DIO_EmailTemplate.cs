namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_EmailTemplate
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int EmailTemplateID { get; set; }

        public int? ActionType { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        [StringLength(255)]
        public string SendTo { get; set; }

        [StringLength(255)]
        public string SendCC { get; set; }

        [StringLength(255)]
        public string SendBCC { get; set; }

        public string Body { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? ScheduleID { get; set; }

        public bool? SendWhenHasIssue { get; set; }

        public int? EmailTransaction { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? HubID { get; set; }

        public int? VendorID { get; set; }

        public virtual DIO_AutomationSchedule DIO_AutomationSchedule { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
