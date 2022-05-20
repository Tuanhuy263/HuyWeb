namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReceivingCarton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReceivingCarton()
        {
            DIO_ReceivingCartonItem = new HashSet<DIO_ReceivingCartonItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceivingCartonNo { get; set; }

        public int? ReceivingUserNo { get; set; }

        public int? ReceivingPalletNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string CartonCode { get; set; }

        public bool? IsScanned { get; set; }

        public bool? HasItem { get; set; }

        public bool? HasDone { get; set; }

        public bool? IsPutAway { get; set; }

        public bool? IsFromWeb { get; set; }

        public virtual DIO_ReceivingPallet DIO_ReceivingPallet { get; set; }

        public virtual DIO_ReceivingUser DIO_ReceivingUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCartonItem> DIO_ReceivingCartonItem { get; set; }
    }
}
