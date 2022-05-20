namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_ASNPOPallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_ASNPOPallet()
        {
            DIS_Carton = new HashSet<DIS_Carton>();
        }

        [Key]
        public int ASNPOPalletNo { get; set; }

        public int? PalletNo { get; set; }

        public int? ASNPONo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? ReplicationDate { get; set; }

        public virtual DIS_ASNPO DIS_ASNPO { get; set; }

        public virtual DIS_Pallet DIS_Pallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_Carton> DIS_Carton { get; set; }
    }
}
