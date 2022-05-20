namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProductTransferResaleDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ProductTransferResaleDetail()
        {
            DIO_ProductTransferResaleLineItem = new HashSet<DIO_ProductTransferResaleLineItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(100)]
        public string DistributorBranchName { get; set; }

        [StringLength(100)]
        public string DistributorBranchNo { get; set; }

        [StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string SupplierNo { get; set; }

        [StringLength(100)]
        public string DivisionHINNumber { get; set; }

        [StringLength(100)]
        public string CustomerHINNumber { get; set; }

        public int? NoOfLineItems { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public int? ProductTransferResaleHeader { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ProductTransferResaleHeader DIO_ProductTransferResaleHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductTransferResaleLineItem> DIO_ProductTransferResaleLineItem { get; set; }
    }
}
