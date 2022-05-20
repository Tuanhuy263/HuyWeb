namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ActivityCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ActivityCode()
        {
            DIO_InventoryValuationAudit = new HashSet<DIO_InventoryValuationAudit>();
            DIO_LocationTransaction = new HashSet<DIO_LocationTransaction>();
        }

        [Key]
        public int ActivityCodeID { get; set; }

        [StringLength(20)]
        public string ActivityCode { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(500)]
        public string TypeName { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryValuationAudit> DIO_InventoryValuationAudit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationTransaction> DIO_LocationTransaction { get; set; }
    }
}
