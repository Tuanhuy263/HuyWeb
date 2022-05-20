namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BrokerPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_BrokerPayment()
        {
            DIO_BrokerPaymentDetail = new HashSet<DIO_BrokerPaymentDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int BrokerPaymentID { get; set; }

        public double? Commission { get; set; }

        public double? Shipped { get; set; }

        public double? CommissionAmount { get; set; }

        public double? PaidCommission { get; set; }

        public double? PaidCommissionAmount { get; set; }

        [StringLength(100)]
        public string CheckNumber { get; set; }

        public DateTime? CheckPaidDate { get; set; }

        public bool? GMPaid { get; set; }

        public int? SaleRepID { get; set; }

        public int? SalesInvoiceID { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? PaymentAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAmount { get; set; }

        public DateTime? PaidDate { get; set; }

        public virtual DIO_SaleRep DIO_SaleRep { get; set; }

        public virtual DIS_SaleInvoiceHeader DIS_SaleInvoiceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BrokerPaymentDetail> DIO_BrokerPaymentDetail { get; set; }
    }
}
