namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_SerialConfiguration
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LastNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MaxNumber { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IncrementNumber { get; set; }

        [StringLength(2048)]
        public string Pattern { get; set; }

        public int? MasterItemID { get; set; }

        public int? UnitOfMeasureID { get; set; }

        public int? VendorID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string FormatNumber { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
