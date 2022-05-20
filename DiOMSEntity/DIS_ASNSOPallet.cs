namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_ASNSOPallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_ASNSOPallet()
        {
            DIO_PackDetail = new HashSet<DIO_PackDetail>();
            DIS_Carton = new HashSet<DIS_Carton>();
        }

        [Key]
        public int ASNSOPalletNo { get; set; }

        public int? PalletNo { get; set; }

        public int? ASNSONo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? PackedUserID { get; set; }

        public bool? IsCreatedByAddPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetail> DIO_PackDetail { get; set; }

        public virtual DIS_ASNSO DIS_ASNSO { get; set; }

        public virtual DIS_User DIS_User { get; set; }

        public virtual DIS_Pallet DIS_Pallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Carton> DIS_Carton { get; set; }
    }
}
