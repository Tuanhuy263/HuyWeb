namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackingTransactionTypeDetailProperty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_TrackingTransactionTypeDetailProperty()
        {
            DIO_TrackingTransactionTypeDetailPropertySample = new HashSet<DIO_TrackingTransactionTypeDetailPropertySample>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TrackingTransactionTypeDetaiPropertylID { get; set; }

        [StringLength(100)]
        public string PropertyName { get; set; }

        [StringLength(100)]
        public string EnumType { get; set; }

        [StringLength(100)]
        public string ValuePropertyPath { get; set; }

        public bool? IsTracked { get; set; }

        public bool? IsTrackingForDeleted { get; set; }

        public bool? IsTrackingForAddNew { get; set; }

        public int? TrackingTransactionTypeDetailID { get; set; }

        public virtual DIO_TrackingTransactionTypeDetail DIO_TrackingTransactionTypeDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingTransactionTypeDetailPropertySample> DIO_TrackingTransactionTypeDetailPropertySample { get; set; }
    }
}
