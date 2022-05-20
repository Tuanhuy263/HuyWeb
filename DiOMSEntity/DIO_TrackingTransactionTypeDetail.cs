namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackingTransactionTypeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_TrackingTransactionTypeDetail()
        {
            DIO_TrackingInfoDetail = new HashSet<DIO_TrackingInfoDetail>();
            DIO_TrackingTransactionTypeDetailProperty = new HashSet<DIO_TrackingTransactionTypeDetailProperty>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TrackingTransactionTypeDetailID { get; set; }

        [StringLength(100)]
        public string DisplayName { get; set; }

        public bool? IsCollection { get; set; }

        [StringLength(100)]
        public string PersistentName { get; set; }

        [StringLength(100)]
        public string PropertyPath { get; set; }

        [StringLength(100)]
        public string DeletePropertyPath { get; set; }

        [StringLength(100)]
        public string AddNewPropertyPath { get; set; }

        public int? TrackingTransactionTypeHeaderID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingInfoDetail> DIO_TrackingInfoDetail { get; set; }

        public virtual DIO_TrackingTransactionTypeHeader DIO_TrackingTransactionTypeHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingTransactionTypeDetailProperty> DIO_TrackingTransactionTypeDetailProperty { get; set; }
    }
}
