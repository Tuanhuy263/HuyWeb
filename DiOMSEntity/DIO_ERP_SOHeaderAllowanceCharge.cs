namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ERP_SOHeaderAllowanceCharge
    {
        [Key]
        public int AllowanceChargeID { get; set; }

        public int SONo { get; set; }

        [Required]
        [StringLength(255)]
        public string QBAllowanceID { get; set; }

        [Required]
        [StringLength(255)]
        public string QBSONo { get; set; }

        public int Indicator { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }
    }
}
