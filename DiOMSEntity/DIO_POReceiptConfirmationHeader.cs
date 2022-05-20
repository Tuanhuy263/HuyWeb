namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_POReceiptConfirmationHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_POReceiptConfirmationHeader()
        {
            DIO_POReceiptConfirmationDetail = new HashSet<DIO_POReceiptConfirmationDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? Status { get; set; }

        [StringLength(100)]
        public string DocumentID { get; set; }

        [StringLength(100)]
        public string SendMethodCode { get; set; }

        [StringLength(100)]
        public string SendMethodDescription { get; set; }

        [StringLength(100)]
        public string SyntaxCheck { get; set; }

        [StringLength(100)]
        public string ISA_Group_Transaction { get; set; }

        public DateTime? AcknowledgedDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? SendDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? SizeInKB { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POReceiptConfirmationDetail> DIO_POReceiptConfirmationDetail { get; set; }
    }
}
