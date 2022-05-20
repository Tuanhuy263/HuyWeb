namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawPallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawPallet()
        {
            DIO_RawASNPOPallet = new HashSet<DIO_RawASNPOPallet>();
            DIO_RawSOASNSOPallet = new HashSet<DIO_RawSOASNSOPallet>();
        }

        [Key]
        public int PalletNo { get; set; }

        public int? SequenceNumber { get; set; }

        [StringLength(50)]
        public string PalletCode { get; set; }

        [StringLength(50)]
        public string PalletCodeQualifier { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawASNPOPallet> DIO_RawASNPOPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawSOASNSOPallet> DIO_RawSOASNSOPallet { get; set; }
    }
}
