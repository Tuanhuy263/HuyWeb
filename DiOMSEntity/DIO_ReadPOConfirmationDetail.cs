namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReadPOConfirmationDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? LineNo { get; set; }

        [StringLength(100)]
        public string TransactionID { get; set; }

        [StringLength(100)]
        public string TradingPartnerID { get; set; }

        [StringLength(100)]
        public string TradingPartnerName { get; set; }

        [StringLength(100)]
        public string TransactionDescription { get; set; }

        [StringLength(100)]
        public string StatusCode { get; set; }

        [StringLength(100)]
        public string StatusDescription { get; set; }

        public int? ReadPOConfirmationHeader { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ReadPOConfirmationHeader DIO_ReadPOConfirmationHeader { get; set; }
    }
}
