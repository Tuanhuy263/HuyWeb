namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ItemQuantityPrice
    {
        [Key]
        public int ItemQuantityPriceID { get; set; }

        public int MasterItemID { get; set; }

        public decimal? FromQuanity { get; set; }

        public decimal? ToQuantity { get; set; }

        public decimal? Price { get; set; }

        public int? Type { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
