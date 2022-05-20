namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_HubReport
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int HubReportID { get; set; }

        public bool? UseDefaultDesign { get; set; }

        public byte[] Design { get; set; }

        [StringLength(100)]
        public string Store { get; set; }

        public bool? UseDefaultStore { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        [StringLength(100)]
        public string Template { get; set; }

        public int? HubID { get; set; }

        public int? ReportFileID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_ReportFile DIO_ReportFile { get; set; }
    }
}
