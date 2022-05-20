namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_NonEDIExportDisplayField
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int NonEDIExportDisplayFieldID { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(255)]
        public string DBFieldName { get; set; }

        [StringLength(255)]
        public string ReportHeaderName { get; set; }

        [StringLength(255)]
        public string ObjectType { get; set; }

        [StringLength(255)]
        public string Source { get; set; }

        [StringLength(255)]
        public string SourceColumnType { get; set; }

        public int? FieldType { get; set; }

        [StringLength(255)]
        public string DefaultValue { get; set; }

        public bool? NotChange { get; set; }

        [StringLength(255)]
        public string Format { get; set; }

        public int? NonEDIExportTemplate { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string FieldName_In_StoreProcedure { get; set; }

        public bool? IsHeader { get; set; }

        public bool? IsDetail { get; set; }

        public bool? IsFooter { get; set; }

        [StringLength(255)]
        public string AlwaysValue { get; set; }

        [StringLength(100)]
        public string PersistentName { get; set; }

        [StringLength(100)]
        public string PropertyName { get; set; }

        [StringLength(100)]
        public string HubCode { get; set; }

        public virtual DIO_NonEDIImportExportTemplate DIO_NonEDIImportExportTemplate { get; set; }
    }
}
