namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ItemDateRangePrice
    {
        [Key]
        public int ItemDateRangePriceID { get; set; }

        public int MasterItemID { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

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

        [Column(TypeName = "money")]
        public decimal? Qty_From { get; set; }

        [Column(TypeName = "money")]
        public decimal? Qty_To { get; set; }

        public int? HubID { get; set; }

        public int? Currency { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
