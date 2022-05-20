namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawSOASNSOPallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawSOASNSOPallet()
        {
            DIO_RawCarton = new HashSet<DIO_RawCarton>();
        }

        [Key]
        public int ASNSOPalletNo { get; set; }

        public int ASNSONo { get; set; }

        public int PalletNo { get; set; }

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
        public virtual ICollection<DIO_RawCarton> DIO_RawCarton { get; set; }

        public virtual DIO_RawPallet DIO_RawPallet { get; set; }

        public virtual DIO_RawSOASNSO DIO_RawSOASNSO { get; set; }
    }
}
