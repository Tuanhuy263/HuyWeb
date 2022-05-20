namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SizeRun
    {
        [Key]
        public int SizeRunID { get; set; }

        public int ParentID { get; set; }

        public int ChildID { get; set; }

        public int? OrderNumber { get; set; }

        public decimal? Quantity { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue { get; set; }

        public virtual DIO_AttributeValue DIO_AttributeValue1 { get; set; }
    }
}
