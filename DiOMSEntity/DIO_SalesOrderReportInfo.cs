namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SalesOrderReportInfo
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(250)]
        public string ReportName { get; set; }

        [StringLength(4000)]
        public string SalesRepIDs { get; set; }

        [StringLength(4000)]
        public string CustomerIDs { get; set; }

        public DateTime? FromSODate { get; set; }

        public DateTime? ToSODate { get; set; }

        public DateTime? DateWillEmailed { get; set; }

        public DateTime? LastDateSentMail { get; set; }

        public bool? IsActive { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
