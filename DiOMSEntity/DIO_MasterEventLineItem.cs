namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_MasterEventLineItem
    {
        [Key]
        public int EventLineItemNo { get; set; }

        public int MasterEventSONo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? PickQty { get; set; }

        public decimal? PickedQty { get; set; }

        public decimal? PackedQty { get; set; }

        public decimal? ShippedQty { get; set; }

        public decimal? ReturnQty { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? SaleOrderDetailID { get; set; }

        public virtual DIO_MasterEventSO DIO_MasterEventSO { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }
    }
}
