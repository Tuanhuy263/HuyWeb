namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_VendorStatement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_VendorStatement()
        {
            DIO_VendorPaymentDetail = new HashSet<DIO_VendorPaymentDetail>();
        }

        [Key]
        public int VendorStatementID { get; set; }

        public int? VendorID { get; set; }

        public int? InvoiceNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(250)]
        public string TransNo { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public decimal? DebitAmount { get; set; }

        public decimal? CreditAmount { get; set; }

        public decimal? Balance { get; set; }

        public DateTime SystemDate { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorPaymentDetail> DIO_VendorPaymentDetail { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
