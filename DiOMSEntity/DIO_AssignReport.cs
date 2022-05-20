namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AssignReport
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AssignReportID { get; set; }

        public bool? NotAllowUpdate { get; set; }

        public int? UserID { get; set; }

        public int? ReportID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_TransactionDetailReport DIO_TransactionDetailReport { get; set; }

        public virtual DIS_User DIS_User { get; set; }
    }
}
