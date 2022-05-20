namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RequestResultHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RequestResultHeader()
        {
            DIO_RequestResultDetail = new HashSet<DIO_RequestResultDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RequestResultHeaderID { get; set; }

        [StringLength(50)]
        public string TradingPartnerID { get; set; }

        [StringLength(4000)]
        public string TransactionNumber { get; set; }

        [StringLength(4000)]
        public string Filename { get; set; }

        public byte? ActionType { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(4000)]
        public string TransactionServiceKey { get; set; }

        public DateTime? RequestedDate { get; set; }

        [StringLength(4000)]
        public string TradingPartnerName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RequestResultDetail> DIO_RequestResultDetail { get; set; }
    }
}
