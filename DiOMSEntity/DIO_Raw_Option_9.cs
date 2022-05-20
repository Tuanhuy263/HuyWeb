namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw_Option_9
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawOption9ID { get; set; }

        [StringLength(50)]
        public string BOLNumber { get; set; }

        [StringLength(200)]
        public string CarrierName { get; set; }

        [StringLength(50)]
        public string ItemID { get; set; }

        [StringLength(200)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string LoadNumber { get; set; }

        [StringLength(50)]
        public string PalletID { get; set; }

        [StringLength(50)]
        public string PalletLineNumber { get; set; }

        [StringLength(50)]
        public string PalletQuantity { get; set; }

        [StringLength(50)]
        public string PONumber { get; set; }

        [StringLength(50)]
        public string ShipDate { get; set; }

        [StringLength(50)]
        public string SONumber { get; set; }

        [StringLength(50)]
        public string ProNumber { get; set; }

        public int? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? HasError { get; set; }

        [StringLength(100)]
        public string CartonNo { get; set; }

        [StringLength(100)]
        public string CartonQuantity { get; set; }

        [StringLength(100)]
        public string CartonVolume { get; set; }

        public bool? IsSendEmail { get; set; }

        public bool? IsErro { get; set; }
    }
}
