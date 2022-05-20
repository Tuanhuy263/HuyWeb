namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_ASNPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_ASNPO()
        {
            DIS_ASNPOPallet = new HashSet<DIS_ASNPOPallet>();
            DIS_Carton = new HashSet<DIS_Carton>();
        }

        [Key]
        public int ASNPONo { get; set; }

        public int? ASNNo { get; set; }

        public int? PONo { get; set; }

        public byte? Status { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? ReplicationDate { get; set; }

        [StringLength(255)]
        public string InvoiceNumber { get; set; }

        [StringLength(1000)]
        public string Special { get; set; }

        [StringLength(255)]
        public string EDISaleInvoiceNumber { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNPOPallet> DIS_ASNPOPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Carton> DIS_Carton { get; set; }
    }
}
