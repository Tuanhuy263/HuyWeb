namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHSTRawReceiptAdvicePallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHSTRawReceiptAdvicePallet()
        {
            DIO_WHSTRawReceiptAdviceCarton = new HashSet<DIO_WHSTRawReceiptAdviceCarton>();
            DIO_WHSTRawReceiptAdviceLineItem = new HashSet<DIO_WHSTRawReceiptAdviceLineItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHSTRawReceiptAdvicePalletID { get; set; }

        public int? SequenceNumber { get; set; }

        [StringLength(100)]
        public string PalletCode { get; set; }

        [StringLength(100)]
        public string PalletCodeQualifier { get; set; }

        public byte? Status { get; set; }

        public int? WHSTRawReceiptAdviceHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHSTRawReceiptAdviceCarton> DIO_WHSTRawReceiptAdviceCarton { get; set; }

        public virtual DIO_WHSTRawReceiptAdviceHeader DIO_WHSTRawReceiptAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHSTRawReceiptAdviceLineItem> DIO_WHSTRawReceiptAdviceLineItem { get; set; }
    }
}
