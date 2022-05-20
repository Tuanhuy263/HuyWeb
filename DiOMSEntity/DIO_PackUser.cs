namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackUser()
        {
            DIO_PackDetail = new HashSet<DIO_PackDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PackUserID { get; set; }

        public int? UserID { get; set; }

        public int? PackHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? IsActived { get; set; }

        public DateTime? PackingTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetail> DIO_PackDetail { get; set; }

        public virtual DIO_PackHeader DIO_PackHeader { get; set; }

        public virtual DIS_User DIS_User { get; set; }
    }
}
