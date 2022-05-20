namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CreditDebitPayment
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CreditDebitPaymentID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public int? CreditDebitMemoID { get; set; }

        public int? CustomerPaymentID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? CreditDebitDetailID { get; set; }

        [StringLength(20)]
        public string BreakdownStructureDetailCode { get; set; }

        [StringLength(20)]
        public string FinancialInformationCode { get; set; }

        public int? NumberOfIncludedSegments { get; set; }

        public int? TransactionSetControlNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? RemainAmount { get; set; }

        public virtual DIO_CreditDebitDetail DIO_CreditDebitDetail { get; set; }

        public virtual DIO_CreditDebitMemo DIO_CreditDebitMemo { get; set; }

        public virtual DIO_CustomerPayment DIO_CustomerPayment { get; set; }
    }
}
