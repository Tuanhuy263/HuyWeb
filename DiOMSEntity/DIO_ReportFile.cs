namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReportFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReportFile()
        {
            DIO_HubReport = new HashSet<DIO_HubReport>();
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
        public int ReportFileID { get; set; }

        [StringLength(100)]
        public string Template { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public bool? UseDefaultStore { get; set; }

        [StringLength(100)]
        public string Store { get; set; }

        public bool? UseDefaultDesign { get; set; }

        public byte[] Design { get; set; }

        [StringLength(100)]
        public string DesignFilePath { get; set; }

        [StringLength(100)]
        public string DesignFileName { get; set; }

        public int? ReportNameID { get; set; }

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string DesignFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubReport> DIO_HubReport { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_ReportName DIO_ReportName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SubReport> DIO_SubReport { get; set; }
    }
}
