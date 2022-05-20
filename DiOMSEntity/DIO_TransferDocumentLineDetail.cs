namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TransferDocumentLineDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TransferDocumentLineDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ReceivedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQty { get; set; }

        public int? ToMasterLocation { get; set; }

        public int? FromMasterLocation { get; set; }

        public int? TransferDocumentDetail { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_TransferDocumentDetail DIO_TransferDocumentDetail { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }
    }
}
