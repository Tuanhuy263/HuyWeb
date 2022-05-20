namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DII_INNER_PACK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DII_INNER_PACK()
        {
            DII_PACK_DETAIL = new HashSet<DII_PACK_DETAIL>();
        }

        [Key]
        public int INNERPACKID { get; set; }

        public int PALLETPACKID { get; set; }

        [StringLength(50)]
        public string INNERPACKCODE { get; set; }

        public long? INNERPACKLINE { get; set; }

        public decimal? INNERPACKQUANTITY { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DII_PACK_DETAIL> DII_PACK_DETAIL { get; set; }

        public virtual DII_PALLET_PACK DII_PALLET_PACK { get; set; }
    }
}
