namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_HubReportField
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? ReportField { get; set; }

        public int? Hub { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? ReportFieldID { get; set; }

        public int? HubID { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(255)]
        public string DBFieldName { get; set; }

        [StringLength(255)]
        public string ReportHeaderName { get; set; }

        public int? FieldType { get; set; }

        [StringLength(250)]
        public string DefaultValue { get; set; }

        public int? Format { get; set; }

        public int? HubReportFieldType { get; set; }

        public int? CustomReportID { get; set; }

        public bool? Header { get; set; }

        public bool? Detail { get; set; }

        public bool? Footer { get; set; }

        public virtual DIO_CustomReport DIO_CustomReport { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Hub DIS_Hub1 { get; set; }

        public virtual DIO_ReportField DIO_ReportField { get; set; }

        public virtual DIO_ReportField DIO_ReportField1 { get; set; }
    }
}
