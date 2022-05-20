namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReceivingUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReceivingUser()
        {
            DIO_ReceivingCarton = new HashSet<DIO_ReceivingCarton>();
            DIO_ReceivingItem = new HashSet<DIO_ReceivingItem>();
            DIO_ReceivingPallet = new HashSet<DIO_ReceivingPallet>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceivingUserNo { get; set; }

        public int? UserId { get; set; }

        public int? ReceivingHeaderNo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string AssignedUsers { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? ModifiedStartDate { get; set; }

        public bool? IsFromWeb { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingCarton> DIO_ReceivingCarton { get; set; }

        public virtual DIO_ReceivingHeader DIO_ReceivingHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingItem> DIO_ReceivingItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingPallet> DIO_ReceivingPallet { get; set; }
    }
}
