namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_Pallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_Pallet()
        {
            DIS_ASNPOPallet = new HashSet<DIS_ASNPOPallet>();
            DIS_ASNSOPallet = new HashSet<DIS_ASNSOPallet>();
            DIS_PalletTransaction = new HashSet<DIS_PalletTransaction>();
        }

        [Key]
        public int PalletNo { get; set; }

        [StringLength(5)]
        public string SequenceNumber { get; set; }

        [StringLength(50)]
        public string PalletCode { get; set; }

        public decimal? Weight { get; set; }

        [StringLength(30)]
        public string Optional5 { get; set; }

        [StringLength(30)]
        public string Optional2 { get; set; }

        [StringLength(30)]
        public string Optional1 { get; set; }

        [StringLength(30)]
        public string Optional3 { get; set; }

        [StringLength(30)]
        public string Optional4 { get; set; }

        public decimal? FreightCharges { get; set; }

        public decimal? HandlingCharges { get; set; }

        public bool? IsVerify { get; set; }

        public bool? Unused { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte? Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNPOPallet> DIS_ASNPOPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASNSOPallet> DIS_ASNSOPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PalletTransaction> DIS_PalletTransaction { get; set; }
    }
}
