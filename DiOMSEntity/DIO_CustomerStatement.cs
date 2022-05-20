namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomerStatement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_CustomerStatement()
        {
            DIO_CustomerPaymentDetail = new HashSet<DIO_CustomerPaymentDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CustomerStatementID { get; set; }

        public DateTime? DocumentDate { get; set; }

        [StringLength(250)]
        public string TransNo { get; set; }

        [StringLength(250)]
        public string StatementNo { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebitAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public DateTime? SystemDate { get; set; }

        public DateTime? TransactionDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? PaymentAmount { get; set; }

        public int? PaidByID { get; set; }

        [StringLength(100)]
        public string CheckNo { get; set; }

        public int? HoldDays { get; set; }

        public int? CurrencyCode { get; set; }

        public int? HubID { get; set; }

        public int? BankNo { get; set; }

        public int? PaymentMethod { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_BankList DIO_BankList { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerPaymentDetail> DIO_CustomerPaymentDetail { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_PaymentMethod DIO_PaymentMethod { get; set; }
    }
}