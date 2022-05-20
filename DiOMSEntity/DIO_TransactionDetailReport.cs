namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TransactionDetailReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_TransactionDetailReport()
        {
            DIO_AssignReport = new HashSet<DIO_AssignReport>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReportID { get; set; }

        [StringLength(250)]
        public string ReportName { get; set; }

        public string Content { get; set; }

        public int? Type { get; set; }

        public bool? IsDefault { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        public string Body { get; set; }

        public int? OptimisticLockField { get; set; }

        public string SQLQuery { get; set; }

        public DateTime? SendMailSuccessfullyDate { get; set; }

        [StringLength(255)]
        public string LayoutPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AssignReport> DIO_AssignReport { get; set; }
    }
}
