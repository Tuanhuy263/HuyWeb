namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Channel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Channel()
        {
            DIO_OrderChangeAcknowledgmentHeader = new HashSet<DIO_OrderChangeAcknowledgmentHeader>();
            DIS_SOHeader = new HashSet<DIS_SOHeader>();
        }

        [Key]
        public int ChannelID { get; set; }

        [Required]
        [StringLength(20)]
        public string ChannelCode { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public int? Priority { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderChangeAcknowledgmentHeader> DIO_OrderChangeAcknowledgmentHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SOHeader> DIS_SOHeader { get; set; }
    }
}
