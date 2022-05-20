namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WarehouseInPool
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WarehouseInPoolID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        [StringLength(255)]
        public string Warehouse { get; set; }

        [StringLength(255)]
        public string Company { get; set; }

        [StringLength(255)]
        public string ShipmentID { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        public DateTime? InPoolDate { get; set; }

        [StringLength(100)]
        public string UOM { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string CompanyName { get; set; }

        [StringLength(255)]
        public string ItemCode { get; set; }
    }
}
