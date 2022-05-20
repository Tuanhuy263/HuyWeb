namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_CustomReport()
        {
            DIO_CustomReport1 = new HashSet<DIO_CustomReport>();
            DIO_HubReportField = new HashSet<DIO_HubReportField>();
            DIO_ReportField = new HashSet<DIO_ReportField>();
            DIO_ReportField1 = new HashSet<DIO_ReportField>();
            DIO_ReportParameter = new HashSet<DIO_ReportParameter>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string StoreName { get; set; }

        public byte[] DefaultValueContent { get; set; }

        [StringLength(4000)]
        public string FilePath { get; set; }

        public int? ParentReportID { get; set; }

        public byte[] ProcedureContent { get; set; }

        [StringLength(100)]
        public string RepxName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomReport> DIO_CustomReport1 { get; set; }

        public virtual DIO_CustomReport DIO_CustomReport2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubReportField> DIO_HubReportField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReportField> DIO_ReportField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReportField> DIO_ReportField1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReportParameter> DIO_ReportParameter { get; set; }
    }
}
