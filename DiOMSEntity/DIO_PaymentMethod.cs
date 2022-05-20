namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PaymentMethod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_PaymentMethod()
        {
            DIO_CustomerPayment = new HashSet<DIO_CustomerPayment>();
            DIO_CustomerStatement = new HashSet<DIO_CustomerStatement>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PaymentMethodID { get; set; }

        [StringLength(100)]
        public string PaymentMethodCode { get; set; }

        [StringLength(100)]
        public string PaymentMethodName { get; set; }

        [StringLength(100)]
        public string PaymentMethodType { get; set; }

        [StringLength(100)]
        public string QBID { get; set; }

        public DateTime? QBModified { get; set; }

        public bool? IsActive { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string QBAccountID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerPayment> DIO_CustomerPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerStatement> DIO_CustomerStatement { get; set; }
    }
}
