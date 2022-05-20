namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PickHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PickHeader()
        {
            DIO_PickDetailBarcode = new HashSet<DIO_PickDetailBarcode>();
            DIO_PickDetailCarton = new HashSet<DIO_PickDetailCarton>();
            DIO_PickDetailItem = new HashSet<DIO_PickDetailItem>();
            DIO_PickDetailPallet = new HashSet<DIO_PickDetailPallet>();
            DIO_PickingProgress = new HashSet<DIO_PickingProgress>();
            DIS_ASN = new HashSet<DIS_ASN>();
        }

        [Key]
        public int PickNo { get; set; }

        [Required]
        [StringLength(255)]
        public string PickNumber { get; set; }

        public DateTime PickDate { get; set; }

        public int? WHOrderNo { get; set; }

        public int? Destination { get; set; }

        public DateTime? EndPick { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? PickingListNo { get; set; }

        public int? ASNNo { get; set; }

        public int? Status { get; set; }

        public int? CreatedUserID { get; set; }

        public bool? WithoutOTS { get; set; }

        [StringLength(100)]
        public string SONumbers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailBarcode> DIO_PickDetailBarcode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailCarton> DIO_PickDetailCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailItem> DIO_PickDetailItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickDetailPallet> DIO_PickDetailPallet { get; set; }

        public virtual DIS_User DIS_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PickingProgress> DIO_PickingProgress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN { get; set; }

        public virtual DIS_ASN DIS_ASN1 { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_PickingList DIO_PickingList { get; set; }

        public virtual DIO_WHOrderHeader DIO_WHOrderHeader { get; set; }
    }
}
