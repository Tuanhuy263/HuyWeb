namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReportField
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReportField()
        {
            DIO_HubReportField = new HashSet<DIO_HubReportField>();
            DIO_HubReportField1 = new HashSet<DIO_HubReportField>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? CustomReport { get; set; }

        [StringLength(100)]
        public string FieldName { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? CustomReportID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? FormatType { get; set; }

        public virtual DIO_CustomReport DIO_CustomReport { get; set; }

        public virtual DIO_CustomReport DIO_CustomReport1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubReportField> DIO_HubReportField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubReportField> DIO_HubReportField1 { get; set; }
    }
}
