namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WarehouseInventoryAdjustment
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(250)]
        public string Warehouse { get; set; }

        [StringLength(250)]
        public string Company { get; set; }

        [StringLength(250)]
        public string Username { get; set; }

        [StringLength(255)]
        public string ActionType { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        public DateTime? AdjustmentDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? Selected { get; set; }

        [StringLength(250)]
        public string DocumentID { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }
    }
}
