namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryAdviceConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryAdviceConfig()
        {
            DIO_InventoryAdviceHeader = new HashSet<DIO_InventoryAdviceHeader>();
            DIO_WarehouseLevelTemplate = new HashSet<DIO_WarehouseLevelTemplate>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public bool? IsUPCRequired { get; set; }

        public bool? IsShownFutureStock { get; set; }

        public bool? IsWarehouseLevels { get; set; }

        public int? ReportFormat { get; set; }

        public int? Delimiter { get; set; }

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string TemplateName { get; set; }

        [StringLength(10)]
        public string OtherDelimiter { get; set; }

        public bool? IsDefault { get; set; }

        public int? ItemSelection { get; set; }

        [StringLength(255)]
        public string FileNameFormat { get; set; }

        [StringLength(255)]
        public string FileIDFormat { get; set; }

        public int? DataFormat { get; set; }

        [StringLength(10)]
        public string ReportExtension { get; set; }

        [Column(TypeName = "money")]
        public decimal? LastFileNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? FileNumberLength { get; set; }

        [StringLength(250)]
        public string StoreProcedureNonEDI { get; set; }

        public bool? IsShowDoubleQuote { get; set; }

        public bool? UseFileNameForFileID { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryAdviceHeader> DIO_InventoryAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WarehouseLevelTemplate> DIO_WarehouseLevelTemplate { get; set; }
    }
}
