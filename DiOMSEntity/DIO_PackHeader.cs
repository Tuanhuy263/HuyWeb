namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackHeader()
        {
            DIO_PackUser = new HashSet<DIO_PackUser>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PackHeaderID { get; set; }

        [StringLength(255)]
        public string DocumentNumber { get; set; }

        public DateTime? PackDate { get; set; }

        public int? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? CreatedUserID { get; set; }

        public bool? WithoutOTS { get; set; }

        public int? ASNID { get; set; }

        [StringLength(100)]
        public string SONumbers { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_User DIS_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackUser> DIO_PackUser { get; set; }
    }
}
