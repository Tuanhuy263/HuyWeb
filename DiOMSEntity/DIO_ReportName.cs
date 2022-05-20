namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReportName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReportName()
        {
            DIO_ReportFile = new HashSet<DIO_ReportFile>();
            DIO_SubReport = new HashSet<DIO_SubReport>();
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

        [StringLength(100)]
        public string ReportName { get; set; }

        [StringLength(100)]
        public string ReportCode { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Store { get; set; }

        public byte[] Design { get; set; }

        [StringLength(300)]
        public string DesignFileName { get; set; }

        [StringLength(500)]
        public string DesignFilePath { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? ReportType { get; set; }

        public bool? IsMenuReport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReportFile> DIO_ReportFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SubReport> DIO_SubReport { get; set; }
    }
}
