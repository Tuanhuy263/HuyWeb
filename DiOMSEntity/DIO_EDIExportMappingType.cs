namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_EDIExportMappingType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_EDIExportMappingType()
        {
            DIO_HubEDIExportMapping = new HashSet<DIO_HubEDIExportMapping>();
            DIO_VendorEDIExportMapping = new HashSet<DIO_VendorEDIExportMapping>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int MappingTypeID { get; set; }

        [StringLength(50)]
        public string MappingTypeCode { get; set; }

        [StringLength(250)]
        public string MappingTypeName { get; set; }

        [StringLength(512)]
        public string DefaultFilename { get; set; }

        [StringLength(512)]
        public string Description { get; set; }

        public byte[] DefaultValueContent { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubEDIExportMapping> DIO_HubEDIExportMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorEDIExportMapping> DIO_VendorEDIExportMapping { get; set; }
    }
}
