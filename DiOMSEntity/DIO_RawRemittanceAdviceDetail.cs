namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawRemittanceAdviceDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawRemittanceAdviceDetailID { get; set; }

        public DateTime? INVCMDate { get; set; }

        [StringLength(50)]
        public string INVCMNumber { get; set; }

        [StringLength(50)]
        public string PONo { get; set; }

        [Column(TypeName = "money")]
        public decimal? INVCMNetAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? INVCMAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? INVCMDiscAmount { get; set; }

        [StringLength(255)]
        public string UserDefined17 { get; set; }

        [StringLength(255)]
        public string UserDefined18 { get; set; }

        [StringLength(255)]
        public string UserDefined19 { get; set; }

        [StringLength(255)]
        public string UserDefined20 { get; set; }

        [StringLength(255)]
        public string UserDefined21 { get; set; }

        public int? RawRemittanceAdviceHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string VoucherNo { get; set; }

        public virtual DIO_RawRemittanceAdviceHeader DIO_RawRemittanceAdviceHeader { get; set; }
    }
}
