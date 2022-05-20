namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AlertBox
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AlertBox()
        {
            DIO_AlertBoxViewHistory = new HashSet<DIO_AlertBoxViewHistory>();
        }

        public int ID { get; set; }

        [StringLength(32)]
        public string Destination { get; set; }

        public DateTime SentDate { get; set; }

        [StringLength(64)]
        public string FromApplication { get; set; }

        [Required]
        [StringLength(64)]
        public string FromUser { get; set; }

        [StringLength(1024)]
        public string Content { get; set; }

        [Required]
        [StringLength(32)]
        public string Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AlertBoxViewHistory> DIO_AlertBoxViewHistory { get; set; }
    }
}
