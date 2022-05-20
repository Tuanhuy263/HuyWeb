namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_MasterEventSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_MasterEventSO()
        {
            DIO_MasterEventLineItem = new HashSet<DIO_MasterEventLineItem>();
            DIS_ASNSO = new HashSet<DIS_ASNSO>();
            DIS_ASN = new HashSet<DIS_ASN>();
            DIO_WHOrderHeader = new HashSet<DIO_WHOrderHeader>();
        }

        [Key]
        public int MasterEventSONo { get; set; }

        public int? MasterEventNo { get; set; }

        [StringLength(255)]
        public string EventNumber { get; set; }

        public int? EventType { get; set; }

        public DateTime? EventDate { get; set; }

        public int? SONo { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? Status { get; set; }

        public virtual DIO_MasterEvent DIO_MasterEvent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_MasterEventLineItem> DIO_MasterEventLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNSO> DIS_ASNSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHOrderHeader> DIO_WHOrderHeader { get; set; }
    }
}
