namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ModuleFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ModuleFile()
        {
            DIO_ModuleFileBatch = new HashSet<DIO_ModuleFileBatch>();
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
        public string FileName { get; set; }

        public int? Type { get; set; }

        [StringLength(100)]
        public string Version { get; set; }

        public string FileContent { get; set; }

        [StringLength(100)]
        public string LatestVersion { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? ModuleID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? HubID { get; set; }

        public int? VendorID { get; set; }

        public virtual DIO_Module DIO_Module { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ModuleFileBatch> DIO_ModuleFileBatch { get; set; }
    }
}
