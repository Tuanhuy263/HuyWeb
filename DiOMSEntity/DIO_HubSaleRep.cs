namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_HubSaleRep
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int HubSaleRepID { get; set; }

        public bool? ApplyDefault { get; set; }

        [Column(TypeName = "money")]
        public decimal? CommissionRate { get; set; }

        public int? HubID { get; set; }

        public int? SaleRepID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_SaleRep DIO_SaleRep { get; set; }
    }
}
