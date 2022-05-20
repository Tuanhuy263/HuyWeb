namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CreditDebitMemo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_CreditDebitMemo()
        {
            DIO_CreditDebitDetail = new HashSet<DIO_CreditDebitDetail>();
            DIO_CreditDebitPayment = new HashSet<DIO_CreditDebitPayment>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CreditDebitMemoID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(32)]
        public string CreditDebitMemoNo { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public int? MemoType { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public int? OptimisticLockField { get; set; }

        public DateTime? CreditDebitDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AmtToUse { get; set; }

        public DateTime? DueDate { get; set; }

        public int? Currency { get; set; }

        public DateTime? CreditDebitMemoDate { get; set; }

        [StringLength(100)]
        public string QBEditSequence { get; set; }

        public DateTime? QBDateModified { get; set; }

        public int? HubID { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainAmount { get; set; }

        [StringLength(32)]
        public string ControlNumber { get; set; }

        [StringLength(32)]
        public string ConventionReference { get; set; }

        [StringLength(32)]
        public string FlagCode { get; set; }

        [StringLength(32)]
        public string TransactionHandlingCode { get; set; }

        [StringLength(32)]
        public string InvoiceNumber { get; set; }

        public DateTime? InvoiceDate { get; set; }

        [StringLength(32)]
        public string VendorOrderNumber { get; set; }

        [StringLength(32)]
        public string BreakdownStructureDetailCode { get; set; }

        [StringLength(32)]
        public string FinancialInformationCode { get; set; }

        public int? NumberOfIncludedSegments { get; set; }

        public int? IdentifierCode { get; set; }

        [StringLength(32)]
        public string PurchaseOrderNumber { get; set; }

        [StringLength(32)]
        public string PurposeCode { get; set; }

        [StringLength(32)]
        public string EntityIdentifierCode { get; set; }

        public byte? Status { get; set; }

        [StringLength(32)]
        public string CurrencyCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CreditDebitDetail> DIO_CreditDebitDetail { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CreditDebitPayment> DIO_CreditDebitPayment { get; set; }
    }
}
