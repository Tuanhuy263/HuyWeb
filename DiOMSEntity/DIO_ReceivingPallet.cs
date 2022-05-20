namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReceivingPallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReceivingPallet()
        {
            DIO_ReceivingCarton = new HashSet<DIO_ReceivingCarton>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceivingPalletNo { get; set; }

        public int? ReceivingUserNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string PalletCode { get; set; }

        public bool? IsScanned { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCarton> DIO_ReceivingCarton { get; set; }

        public virtual DIO_ReceivingUser DIO_ReceivingUser { get; set; }
    }
}
