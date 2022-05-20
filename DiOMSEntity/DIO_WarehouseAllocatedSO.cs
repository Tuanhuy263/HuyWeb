namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WarehouseAllocatedSO
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
        public string ShipmentID { get; set; }

        [StringLength(255)]
        public string CompanyName { get; set; }

        [StringLength(255)]
        public string TrailingStatus { get; set; }

        [StringLength(255)]
        public string LeadingStatus { get; set; }

        [StringLength(255)]
        public string InternalShipmentNumber { get; set; }

        [StringLength(255)]
        public string ERPItemCode { get; set; }

        public DateTime? ScheduleShipDate { get; set; }

        public DateTime? CreateDateStamp { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? RequestQty { get; set; }

        public int? OptimisticLockField { get; set; }

        public DateTime? FileDate { get; set; }

        public int? MasterItemID { get; set; }

        public int? MasterLocationID { get; set; }
    }
}
