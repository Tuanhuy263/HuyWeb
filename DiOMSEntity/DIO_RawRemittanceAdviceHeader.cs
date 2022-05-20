namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawRemittanceAdviceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawRemittanceAdviceHeader()
        {
            DIO_RawRemittanceAdviceDetail = new HashSet<DIO_RawRemittanceAdviceDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int RawRemittanceAdviceHeaderID { get; set; }

        [StringLength(50)]
        public string TransControlNo { get; set; }

        [StringLength(50)]
        public string TransType { get; set; }

        public DateTime? CheckDate { get; set; }

        [StringLength(50)]
        public string CheckNumber { get; set; }

        [StringLength(50)]
        public string Currency { get; set; }

        [Column(TypeName = "money")]
        public decimal? CheckAmount { get; set; }

        [StringLength(255)]
        public string UserDefined6 { get; set; }

        [StringLength(255)]
        public string UserDefined7 { get; set; }

        [StringLength(255)]
        public string UserDefined8 { get; set; }

        [StringLength(255)]
        public string UserDefined9 { get; set; }

        [StringLength(255)]
        public string UserDefined10 { get; set; }

        public int? InvalidRawSIType { get; set; }

        public int? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? InvalidRawType { get; set; }

        [StringLength(100)]
        public string CreditOrDebit { get; set; }

        [StringLength(100)]
        public string PayerName { get; set; }

        [StringLength(100)]
        public string PayeeName { get; set; }

        [StringLength(100)]
        public string RecBankABA { get; set; }

        [StringLength(100)]
        public string RecBankAorC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawRemittanceAdviceDetail> DIO_RawRemittanceAdviceDetail { get; set; }
    }
}
