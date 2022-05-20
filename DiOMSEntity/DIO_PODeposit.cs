namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PODeposit
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PODepositID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Percentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime? DepositDate { get; set; }

        public int? PONo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }
    }
}
