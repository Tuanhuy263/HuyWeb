namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_StockInExpenditure
    {
        [Key]
        public int StockInExpenditureID { get; set; }

        public int ExpenditureID { get; set; }

        public int? WHStockInNo { get; set; }

        public decimal Amount { get; set; }

        public byte? DistributedMethod { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? LandedCostHeaderNo { get; set; }

        public virtual DIO_Expenditure DIO_Expenditure { get; set; }

        public virtual DIO_LandedCostHeader DIO_LandedCostHeader { get; set; }

        public virtual DIO_WHStockIn DIO_WHStockIn { get; set; }
    }
}
