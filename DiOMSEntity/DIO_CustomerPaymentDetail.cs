namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomerPaymentDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CustomerPaymentDetailID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? InvoiceNo { get; set; }

        public int? CustomerPayementID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? CustomerStatementID { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [StringLength(100)]
        public string VoucherNo { get; set; }

        public int? CustomerPaymentID { get; set; }

        public DateTime? DocumentDate { get; set; }

        [StringLength(100)]
        public string InvoiceNumber { get; set; }

        [StringLength(100)]
        public string SOOriginalNumber { get; set; }

        [StringLength(100)]
        public string EDISONumber { get; set; }

        [StringLength(100)]
        public string SONumber { get; set; }

        public int? SONo { get; set; }

        public virtual DIO_CustomerPayment DIO_CustomerPayment { get; set; }

        public virtual DIO_CustomerPayment DIO_CustomerPayment1 { get; set; }

        public virtual DIO_CustomerStatement DIO_CustomerStatement { get; set; }

        public virtual DIS_SaleInvoiceHeader DIS_SaleInvoiceHeader { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }
    }
}
