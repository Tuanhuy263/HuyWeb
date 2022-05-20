namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw997
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string HubCode { get; set; }

        [StringLength(250)]
        public string SONumber { get; set; }

        [StringLength(250)]
        public string FileName { get; set; }

        public int? Status { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string Warehouse { get; set; }

        [StringLength(255)]
        public string Company { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        [StringLength(255)]
        public string TrailingStatus { get; set; }

        [StringLength(255)]
        public string LeadingStatus { get; set; }

        public DateTime? ScheduleShipDate { get; set; }
    }
}
