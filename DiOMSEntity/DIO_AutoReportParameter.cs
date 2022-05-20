namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutoReportParameter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AutoReportParameter()
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
        public int AutoReportParameterID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Mode { get; set; }

        [StringLength(100)]
        public string Parameter { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(1000)]
        public string Value { get; set; }

        public int? SONo { get; set; }

        public int? AutoReportNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutoReport> DIO_AutoReport { get; set; }

        public virtual DIO_AutoReport DIO_AutoReport1 { get; set; }

        public virtual DIO_AutoReport DIO_AutoReport2 { get; set; }
    }
}
