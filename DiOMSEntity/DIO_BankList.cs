namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BankList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_BankList()
        {
            DIO_CustomerPayment = new HashSet<DIO_CustomerPayment>();
            DIO_CustomerStatement = new HashSet<DIO_CustomerStatement>();
        }

        [Key]
        public int BankListID { get; set; }

        [Required]
        [StringLength(10)]
        public string BankNo { get; set; }

        [StringLength(200)]
        public string BankName { get; set; }

        public int? GLAccountID { get; set; }

        [StringLength(50)]
        public string AccountNo { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerPayment> DIO_CustomerPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerStatement> DIO_CustomerStatement { get; set; }

        public virtual DIO_GLAccount DIO_GLAccount { get; set; }
    }
}
