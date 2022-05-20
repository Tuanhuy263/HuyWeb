namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProductTransferResaleHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ProductTransferResaleHeader()
        {
            DIO_ProductTransferResaleDetail = new HashSet<DIO_ProductTransferResaleDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(50)]
        public string TransactionControlNumber { get; set; }

        [StringLength(3)]
        public string DocumentType { get; set; }

        [StringLength(100)]
        public string TransType { get; set; }

        [StringLength(100)]
        public string InvoiceNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        [StringLength(3)]
        public string TransactionIdentifierCode { get; set; }

        public DateTime? ReportDate { get; set; }

        public DateTime? ReportStartDate { get; set; }

        public DateTime? ReportEndDate { get; set; }

        [StringLength(100)]
        public string ReportType { get; set; }

        [StringLength(10)]
        public string HubCode { get; set; }

        [StringLength(50)]
        public string HubName { get; set; }

        [StringLength(200)]
        public string HubAddress1 { get; set; }

        [StringLength(25)]
        public string HubCity { get; set; }

        [StringLength(2)]
        public string HubState { get; set; }

        [StringLength(15)]
        public string HubZipcode { get; set; }

        [StringLength(25)]
        public string HubCountry { get; set; }

        [StringLength(25)]
        public string HubContactName { get; set; }

        [StringLength(25)]
        public string HubContactPhone { get; set; }

        [StringLength(25)]
        public string HubContactFax { get; set; }

        public int? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductTransferResaleDetail> DIO_ProductTransferResaleDetail { get; set; }
    }
}
