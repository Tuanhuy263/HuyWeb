namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIOW_LocationItemPars
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? LocID { get; set; }

        public int? MasterItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Restock { get; set; }

        [Column(TypeName = "money")]
        public decimal? MaxCapacity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ModelStock { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
