namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BOLCustomerInfo
    {
        public int ID { get; set; }

        public int? BOLID { get; set; }

        [StringLength(255)]
        public string StoreBill { get; set; }

        [StringLength(255)]
        public string SOOriginalNumber { get; set; }

        [StringLength(255)]
        public string SONumber { get; set; }

        public int? NumberOfPallets { get; set; }

        public int? NumberOfCartons { get; set; }

        public int? NumberOfPieces { get; set; }

        public byte? IsPallet { get; set; }

        public byte? IsSlip { get; set; }

        [StringLength(50)]
        public string Destination { get; set; }

        [StringLength(50)]
        public string POType { get; set; }

        [StringLength(50)]
        public string Dept { get; set; }

        [StringLength(50)]
        public string MasterPro { get; set; }

        [StringLength(50)]
        public string TrackingNumber { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Weight { get; set; }

        [StringLength(100)]
        public string ASNNo { get; set; }

        [StringLength(100)]
        public string ShippingInfoStore { get; set; }

        public int? ParentCustomerID { get; set; }

        [StringLength(100)]
        public string AdditionalShipperInfo { get; set; }

        [StringLength(100)]
        public string ListPallets { get; set; }

        public bool? IsPrintBOLMasterByComponents { get; set; }

        public virtual DIO_MasterBOL DIO_MasterBOL { get; set; }
    }
}
