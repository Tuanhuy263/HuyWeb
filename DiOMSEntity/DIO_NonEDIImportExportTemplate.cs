namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_NonEDIImportExportTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_NonEDIImportExportTemplate()
        {
            DIO_NonEDIExportDisplayField = new HashSet<DIO_NonEDIExportDisplayField>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int NonEDIImportExportTemplateID { get; set; }

        [StringLength(255)]
        public string TemplateName { get; set; }

        [StringLength(255)]
        public string Transaction { get; set; }

        public int? TransactionID { get; set; }

        [StringLength(100)]
        public string ObjectType { get; set; }

        public int? ReportFormat { get; set; }

        public int? DataFormat { get; set; }

        public int? Delimiter { get; set; }

        public bool? IsDefault { get; set; }

        [StringLength(50)]
        public string OtherDelimiter { get; set; }

        [StringLength(255)]
        public string FileNameFormat { get; set; }

        [StringLength(255)]
        public string FileIDFormat { get; set; }

        [StringLength(10)]
        public string ReportExtension { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastFileNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? FileNumberLength { get; set; }

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? TemplateType { get; set; }

        [StringLength(255)]
        public string TransactionKeyColumnName { get; set; }

        [StringLength(255)]
        public string HubKeyColumnName { get; set; }

        [StringLength(255)]
        public string FolderName { get; set; }

        [StringLength(100)]
        public string ExportStoredName { get; set; }

        public byte[] MappingContent { get; set; }

        public bool? ShowCaption { get; set; }

        public bool? IsEnclosedInQuotes { get; set; }

        public int? MasterdataTrans { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public bool? HideMapping { get; set; }

        public bool? IsEDI { get; set; }

        public byte[] CrosstabMappingContent { get; set; }

        [StringLength(255)]
        public string SpecificFolder { get; set; }

        public int? CaptionRowIndex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_NonEDIExportDisplayField> DIO_NonEDIExportDisplayField { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }
    }
}
