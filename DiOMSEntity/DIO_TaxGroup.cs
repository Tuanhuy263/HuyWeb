namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TaxGroup
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TaxGroupID { get; set; }

        public int? ParentTax { get; set; }

        public int? ChildTax { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIO_Tax DIO_Tax1 { get; set; }
    }
}
