namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ExternalServiceFunction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ExternalServiceFunction()
        {
            DIO_ExternalServiceInput = new HashSet<DIO_ExternalServiceInput>();
            DIO_ExternalServiceOutput = new HashSet<DIO_ExternalServiceOutput>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ExternalServiceFunctionID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string FunctionName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? ExternalService { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ExternalService DIO_ExternalService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ExternalServiceInput> DIO_ExternalServiceInput { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ExternalServiceOutput> DIO_ExternalServiceOutput { get; set; }
    }
}
