namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReplenishDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReplenishDetailNo { get; set; }

        [StringLength(500)]
        public string LocationCodeFrom { get; set; }

        [StringLength(500)]
        public string PalletCodeFrom { get; set; }

        [StringLength(500)]
        public string LocationCodeTo { get; set; }

        [StringLength(500)]
        public string PalletCodeTo { get; set; }

        [StringLength(100)]
        public string ItemCode { get; set; }

        [StringLength(50)]
        public string UOM { get; set; }

        public int? SuggestedQty { get; set; }

        public int? PickedQty { get; set; }

        public int? ScannedQty { get; set; }

        public int? UnpackedQty { get; set; }

        [StringLength(100)]
        public string UnpackedItemCode { get; set; }

        public int? BatchID { get; set; }

        public int? ReplenishHeader { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ReplenishHeader DIO_ReplenishHeader { get; set; }
    }
}
