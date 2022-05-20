namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Module
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Module()
        {
            DIO_ModuleFile = new HashSet<DIO_ModuleFile>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string DefaultDisplayName { get; set; }

        [StringLength(4000)]
        public string TransactionType { get; set; }

        [StringLength(4000)]
        public string Assembly { get; set; }

        [StringLength(4000)]
        public string MapFile { get; set; }

        public bool? Enable { get; set; }

        public int? OptimisticLockField { get; set; }

        public string CommonModuleFileMap { get; set; }

        public int? FlowType { get; set; }

        public int? FormulaOrder { get; set; }

        public int? DefaultValuesOrder { get; set; }

        [StringLength(4000)]
        public string ValidationFileName { get; set; }

        public string CommonModuleFileValidation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ModuleFile> DIO_ModuleFile { get; set; }
    }
}
