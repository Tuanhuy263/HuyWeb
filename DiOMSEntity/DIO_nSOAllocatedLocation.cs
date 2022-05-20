namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_nSOAllocatedLocation
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? DISODAllocationInfo { get; set; }

        public int? CustomerSO { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatingQty { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOAllocatedLocationKey { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_nCustomerSO DIO_nCustomerSO { get; set; }

        public virtual DISODAllocationInfo DISODAllocationInfo1 { get; set; }
    }
}
