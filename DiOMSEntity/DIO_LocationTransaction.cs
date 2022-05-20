namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LocationTransaction
    {
        [Key]
        public int LocationTransactionID { get; set; }

        [StringLength(103)]
        public string DocumentNo { get; set; }

        public int? ActivityCodeID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? MasterItemID { get; set; }

        public DateTime? UpdateDate { get; set; }

        public decimal? Onhand { get; set; }

        public decimal? TransactionQty { get; set; }

        public decimal? UnitCost { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_ActivityCode DIO_ActivityCode { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }
    }
}
