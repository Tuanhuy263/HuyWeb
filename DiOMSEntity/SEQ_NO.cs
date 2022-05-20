namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SEQ_NO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEQ_NO()
        {
            SEQ_Group = new HashSet<SEQ_Group>();
        }

        [Key]
        public int SEQNoID { get; set; }

        [Required]
        [StringLength(100)]
        public string TranType { get; set; }

        [StringLength(50)]
        public string Prefix { get; set; }

        public int? LastNumber { get; set; }

        public short? Length { get; set; }

        public bool? Year { get; set; }

        public bool? Month { get; set; }

        public short? LastYear { get; set; }

        public short? LastMonth { get; set; }

        [StringLength(50)]
        public string YearSeparate { get; set; }

        [StringLength(50)]
        public string MonthSeparate { get; set; }

        public bool? IsMultiGroup { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEQ_Group> SEQ_Group { get; set; }
    }
}
