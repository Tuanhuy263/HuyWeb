namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackingTransactionTypeHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_TrackingTransactionTypeHeader()
        {
            DIO_TrackingInfoHeader = new HashSet<DIO_TrackingInfoHeader>();
            DIO_TrackingTransactionTypeDetail = new HashSet<DIO_TrackingTransactionTypeDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TrackingTransactionTypeID { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        [StringLength(100)]
        public string PersistentName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingInfoHeader> DIO_TrackingInfoHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingTransactionTypeDetail> DIO_TrackingTransactionTypeDetail { get; set; }
    }
}
