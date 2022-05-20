namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHRecipientNoticeDetail
    {
        [Key]
        public int WHRecipientNoticeDetailNo { get; set; }

        public int WHRecipientNoticeNo { get; set; }

        public int MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? StockInQty { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? MasterLocationID { get; set; }

        public int? PurchaseOrderDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? UOMRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderedQty { get; set; }

        public DateTime? ExpiredDate { get; set; }

        [StringLength(50)]
        public string LotNo { get; set; }

        [StringLength(300)]
        public string Note { get; set; }

        [StringLength(100)]
        public string UOMCode { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_WHRecipientNoticeHeader DIO_WHRecipientNoticeHeader { get; set; }
    }
}
