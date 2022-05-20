namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TrackingInfoHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_TrackingInfoHeader()
        {
            DIO_TrackingInfoDetail = new HashSet<DIO_TrackingInfoDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TrackingInfoHeaderID { get; set; }

        public int? ActionType { get; set; }

        [StringLength(100)]
        public string ObjectType { get; set; }

        [StringLength(100)]
        public string ObjectID { get; set; }

        [StringLength(100)]
        public string ObjectKey { get; set; }

        [StringLength(100)]
        public string Username { get; set; }

        [StringLength(100)]
        public string ComputerName { get; set; }

        public string ObjectContent { get; set; }

        [StringLength(100)]
        public string IPAddress { get; set; }

        public int? TrackingTransactionTypeHeaderID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_TrackingInfoDetail> DIO_TrackingInfoDetail { get; set; }

        public virtual DIO_TrackingTransactionTypeHeader DIO_TrackingTransactionTypeHeader { get; set; }
    }
}
