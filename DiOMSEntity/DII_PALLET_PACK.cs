namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DII_PALLET_PACK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DII_PALLET_PACK()
        {
            DII_INNER_PACK = new HashSet<DII_INNER_PACK>();
        }

        [Key]
        public int PALLETPACKID { get; set; }

        [StringLength(2)]
        public string CONTAINERQUALIFIER { get; set; }

        [StringLength(48)]
        public string CONTAINERCODE { get; set; }

        [StringLength(255)]
        public string CARTONNUMBERDC { get; set; }

        public decimal? CARTONVOLUME { get; set; }

        public decimal? CARTONWEIGHT { get; set; }

        public int ASNPOID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DII_ASN_PO DII_ASN_PO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DII_INNER_PACK> DII_INNER_PACK { get; set; }
    }
}
