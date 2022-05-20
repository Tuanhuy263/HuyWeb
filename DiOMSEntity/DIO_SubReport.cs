namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SubReport
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReportID { get; set; }

        [StringLength(255)]
        public string SubReportName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Store { get; set; }

        public byte[] Design { get; set; }

        [StringLength(255)]
        public string DesignFileName { get; set; }

        [StringLength(255)]
        public string DesignFilePath { get; set; }

        public int? ReportNameID { get; set; }

        public int? ReportFileID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ReportFile DIO_ReportFile { get; set; }

        public virtual DIO_ReportName DIO_ReportName { get; set; }
    }
}
