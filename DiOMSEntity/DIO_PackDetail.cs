namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PackDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PackDetail()
        {
            DIO_PackDetailCarton = new HashSet<DIO_PackDetailCarton>();
            DIO_PackDetailItem = new HashSet<DIO_PackDetailItem>();
            DIO_PackDetailPallet = new HashSet<DIO_PackDetailPallet>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PackDetailID { get; set; }

        public int? PackUserID { get; set; }

        public int? ASNID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? CartonID { get; set; }

        public int? ShippingLocationID { get; set; }

        public int? PalletID { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_Carton DIS_Carton { get; set; }

        public virtual DIO_PackUser DIO_PackUser { get; set; }

        public virtual DIS_ASNSOPallet DIS_ASNSOPallet { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailCarton> DIO_PackDetailCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailItem> DIO_PackDetailItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetailPallet> DIO_PackDetailPallet { get; set; }
    }
}
