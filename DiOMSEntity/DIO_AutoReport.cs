namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutoReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AutoReport()
        {
            DIO_AutoReportParameter1 = new HashSet<DIO_AutoReportParameter>();
            DIO_AutoReportParameter2 = new HashSet<DIO_AutoReportParameter>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AutoReportID { get; set; }

        [StringLength(100)]
        public string ReportCode { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? Time { get; set; }

        public int? SendToEmail { get; set; }

        public int? Parameters { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? HubID { get; set; }

        public int? MasterItem { get; set; }

        public bool? IsEnabled { get; set; }

        public int? ScheduleID { get; set; }

        public virtual DIO_AutomationSchedule DIO_AutomationSchedule { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIO_AutoReportParameter DIO_AutoReportParameter { get; set; }

        public virtual DIO_AutoReportEmail DIO_AutoReportEmail { get; set; }

        public virtual DIO_AutoReportTime DIO_AutoReportTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutoReportParameter> DIO_AutoReportParameter1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutoReportParameter> DIO_AutoReportParameter2 { get; set; }
    }
}
