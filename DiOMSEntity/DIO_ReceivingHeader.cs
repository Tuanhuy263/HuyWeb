namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReceivingHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ReceivingHeader()
        {
            DIO_ReceivingUser = new HashSet<DIO_ReceivingUser>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceivingHeaderNo { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string DocumentNo { get; set; }

        [StringLength(250)]
        public string BOLNumber { get; set; }

        public DateTime? ReceiveDate { get; set; }

        public long? Status { get; set; }

        public int? Mode { get; set; }

        public int? Type { get; set; }

        public int? ToLocationID { get; set; }

        public int? Vendor { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? CreatedUserId { get; set; }

        [StringLength(100)]
        public string EndReceivingBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? BarcodeTypeInput { get; set; }

        [StringLength(250)]
        public string PONumber { get; set; }

        public bool? IsFromWeb { get; set; }

        public bool? IsPutAway { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingUser> DIO_ReceivingUser { get; set; }
    }
}
