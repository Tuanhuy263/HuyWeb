namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_FTPAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_FTPAccount()
        {
            DIO_FTPAccountNonEDI = new HashSet<DIO_FTPAccountNonEDI>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int FTPAccountID { get; set; }

        [StringLength(100)]
        public string FTPAccountCode { get; set; }

        [StringLength(100)]
        public string FTPAccountName { get; set; }

        [StringLength(100)]
        public string Server { get; set; }

        public int? Port { get; set; }

        [StringLength(100)]
        public string Username { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string UploadPath { get; set; }

        [StringLength(100)]
        public string DownloadPath { get; set; }

        public bool? DefaultDownload { get; set; }

        public bool? DefaultUpload { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? HubID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FTPServerType { get; set; }

        public int? VendorID { get; set; }

        [StringLength(100)]
        public string ArchiveFolder { get; set; }

        public bool? IsUseRootPath { get; set; }

        public bool? FTPIsActiveMode { get; set; }

        public bool? IsNonEDI { get; set; }

        public bool? ForSalesOrder { get; set; }

        public bool? ForPurchaseOrder { get; set; }

        public bool? ForSalesInvoice { get; set; }

        public bool? ForPurchaseInvoice { get; set; }

        public bool? For846 { get; set; }

        public bool? ForInboundASN { get; set; }

        public bool? For944 { get; set; }

        public bool? For943 { get; set; }

        [StringLength(100)]
        public string ReportFolder { get; set; }

        [StringLength(100)]
        public string Protocol { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FTPType { get; set; }

        public bool? For945 { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_FTPAccountNonEDI> DIO_FTPAccountNonEDI { get; set; }
    }
}
