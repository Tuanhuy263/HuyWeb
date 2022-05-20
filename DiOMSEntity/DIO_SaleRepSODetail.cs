namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SaleRepSODetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int SaleRepSODetailID { get; set; }

        public int? SaleRep { get; set; }

        [Column(TypeName = "money")]
        public decimal? CommissionRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? CommissionAmount { get; set; }

        public int? SODetail { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_SaleRep DIO_SaleRep { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }
    }
}
