namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutoReportTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AutoReportTime()
        {
            DIO_AutoReport = new HashSet<DIO_AutoReport>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AutoReportTimeID { get; set; }

        [StringLength(300)]
        public string Months { get; set; }

        [StringLength(300)]
        public string Dates { get; set; }

        [StringLength(300)]
        public string WeekDays { get; set; }

        [StringLength(300)]
        public string Hours { get; set; }

        [StringLength(300)]
        public string Minutes { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutoReport> DIO_AutoReport { get; set; }
    }
}
