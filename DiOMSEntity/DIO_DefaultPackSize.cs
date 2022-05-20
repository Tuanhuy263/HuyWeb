namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_DefaultPackSize
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int DefaultPackSizeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? PackQty { get; set; }

        public int? HubItemID { get; set; }

        public int? UOMID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? MasterItemID { get; set; }

        public virtual DIS_HubItem DIS_HubItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }
    }
}
