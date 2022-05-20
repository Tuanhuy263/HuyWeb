namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BrokerPaymentDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int BrokerPaymentDetailID { get; set; }

        [StringLength(255)]
        public string ItemCode { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public double? Shipped { get; set; }

        public double? Paid { get; set; }

        public double? Commission { get; set; }

        public double? CommissionAmount { get; set; }

        public int? BrokerPaymentID { get; set; }

        public int? UOM { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_BrokerPayment DIO_BrokerPayment { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
