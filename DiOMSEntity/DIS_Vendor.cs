namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_Vendor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_Vendor()
        {
            DIO_AppointmentSecurityLog = new HashSet<DIO_AppointmentSecurityLog>();
            DIO_ASNLabelTemplate = new HashSet<DIO_ASNLabelTemplate>();
            DIO_AssignVendor = new HashSet<DIO_AssignVendor>();
            DIO_BankAddress = new HashSet<DIO_BankAddress>();
            DIO_Batch = new HashSet<DIO_Batch>();
            DIO_BlanketPOHeader = new HashSet<DIO_BlanketPOHeader>();
            DIO_DefaultShippingInfo = new HashSet<DIO_DefaultShippingInfo>();
            DIO_EDIExportTrack = new HashSet<DIO_EDIExportTrack>();
            DIO_EmailTemplate = new HashSet<DIO_EmailTemplate>();
            DIO_ERP_Vendor = new HashSet<DIO_ERP_Vendor>();
            DIO_FTPAccount = new HashSet<DIO_FTPAccount>();
            DIO_ModuleFile = new HashSet<DIO_ModuleFile>();
            DIO_PrintTemplate = new HashSet<DIO_PrintTemplate>();
            DIO_PrintTemplateHubVendor = new HashSet<DIO_PrintTemplateHubVendor>();
            DIO_ProductCodes = new HashSet<DIO_ProductCodes>();
            DIO_ReceivingHeader = new HashSet<DIO_ReceivingHeader>();
            DIO_SerialConfiguration = new HashSet<DIO_SerialConfiguration>();
            DIO_VendorBatch = new HashSet<DIO_VendorBatch>();
            DIO_VendorContactInfo = new HashSet<DIO_VendorContactInfo>();
            DIO_VendorEDIExportMapping = new HashSet<DIO_VendorEDIExportMapping>();
            DIO_VendorEDIMapping = new HashSet<DIO_VendorEDIMapping>();
            DIO_VendorFreight = new HashSet<DIO_VendorFreight>();
            DIO_VendorMarkForStore = new HashSet<DIO_VendorMarkForStore>();
            DIO_VendorShippingInfo = new HashSet<DIO_VendorShippingInfo>();
            DIO_VendorStatement = new HashSet<DIO_VendorStatement>();
            DIO_WHStockIn = new HashSet<DIO_WHStockIn>();
            DIO_WSTShipmentAdviceHeader = new HashSet<DIO_WSTShipmentAdviceHeader>();
            DIS_MasterLocation = new HashSet<DIS_MasterLocation>();
            DIS_POHeader = new HashSet<DIS_POHeader>();
            DIS_VendorItem = new HashSet<DIS_VendorItem>();
        }

        [Key]
        public int VendorID { get; set; }

        [Required]
        [StringLength(50)]
        public string VENDOR_NO { get; set; }

        [StringLength(50)]
        public string VENDUNS { get; set; }

        [StringLength(150)]
        public string VendorName { get; set; }

        public int CurrencyCode { get; set; }

        public int? PaymentTermID { get; set; }

        [StringLength(255)]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        public string FaxNumber { get; set; }

        [StringLength(200)]
        public string VENADR1 { get; set; }

        [StringLength(200)]
        public string VENADR2 { get; set; }

        public int? VENZONE_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal? VENMINORDERVALUE { get; set; }

        public int? VENMINORDERQTY { get; set; }

        [StringLength(10)]
        public string VENMANUFACTURERID { get; set; }

        [StringLength(50)]
        public string CURRENT850ID { get; set; }

        [StringLength(50)]
        public string CURRENT855ID { get; set; }

        public bool? VEN_OPTID1 { get; set; }

        [StringLength(200)]
        public string VEN_OPTID2 { get; set; }

        public bool? VEN_OPTID3 { get; set; }

        [StringLength(50)]
        public string VEN_OPTID4 { get; set; }

        public int? PREORDERQTY { get; set; }

        [Column(TypeName = "money")]
        public decimal? PREORDERVALUE { get; set; }

        [StringLength(50)]
        public string VEN_OPTID5 { get; set; }

        public bool? VMI { get; set; }

        public bool? BackOrder { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public bool? IsOverShip { get; set; }

        public decimal? PercentOverShip { get; set; }

        public bool? DefaultVendor { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(255)]
        public string QBAccountNumber { get; set; }

        [StringLength(255)]
        public string QBVendorID { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public DateTime? QBModified { get; set; }

        [Column(TypeName = "money")]
        public decimal? VendorBalance { get; set; }

        public int? VendorTermID { get; set; }

        [StringLength(110)]
        public string AccountNo { get; set; }

        public bool? IsVendorEDI { get; set; }

        [StringLength(255)]
        public string MainProductCodeQualifiers { get; set; }

        public DateTime? LastSyncDate { get; set; }

        [StringLength(100)]
        public string Instructional { get; set; }

        [StringLength(100)]
        public string InternalMemo { get; set; }

        [StringLength(100)]
        public string InternalNotes { get; set; }

        [StringLength(4000)]
        public string DestinationPathOfExportedFile { get; set; }

        [StringLength(100)]
        public string SmartTurnVendorCode { get; set; }

        [StringLength(100)]
        public string SmartTurnVendorName { get; set; }

        [StringLength(500)]
        public string ManufacturerAddress { get; set; }

        [StringLength(200)]
        public string ManufacturerName { get; set; }

        [StringLength(20)]
        public string FDARegistrationNo { get; set; }

        [StringLength(20)]
        public string DeviceListing { get; set; }

        [StringLength(20)]
        public string OwnerOperator { get; set; }

        [StringLength(10)]
        public string ProductCode { get; set; }

        public bool? isTurnOnERPTerm { get; set; }

        public bool? IsGetERPTerm { get; set; }

        [Column("_GetTermFromVendor")]
        public bool? C_GetTermFromVendor { get; set; }

        public bool? GetERPTermFromVendor { get; set; }

        [StringLength(30)]
        public string GS1CompanyPrefix { get; set; }

        [StringLength(1000)]
        public string PortOfLoading { get; set; }

        public int? QBClassID { get; set; }

        public int? QBTemplateID { get; set; }

        public int? QBAccountID { get; set; }

        public bool? CreateOutboundWithShipped { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AppointmentSecurityLog> DIO_AppointmentSecurityLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ASNLabelTemplate> DIO_ASNLabelTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AssignVendor> DIO_AssignVendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BankAddress> DIO_BankAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Batch> DIO_Batch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BlanketPOHeader> DIO_BlanketPOHeader { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_DefaultShippingInfo> DIO_DefaultShippingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EDIExportTrack> DIO_EDIExportTrack { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EmailTemplate> DIO_EmailTemplate { get; set; }

        public virtual DIO_ERP_Term DIO_ERP_Term { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ERP_Vendor> DIO_ERP_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_FTPAccount> DIO_FTPAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ModuleFile> DIO_ModuleFile { get; set; }

        public virtual DIO_PaymentTerm DIO_PaymentTerm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PrintTemplate> DIO_PrintTemplate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PrintTemplateHubVendor> DIO_PrintTemplateHubVendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductCodes> DIO_ProductCodes { get; set; }

        public virtual DIO_QBClass DIO_QBClass { get; set; }

        public virtual DIO_QBTemplate DIO_QBTemplate { get; set; }

        public virtual DIO_QuickBookAccount DIO_QuickBookAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ReceivingHeader> DIO_ReceivingHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SerialConfiguration> DIO_SerialConfiguration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorBatch> DIO_VendorBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorContactInfo> DIO_VendorContactInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorEDIExportMapping> DIO_VendorEDIExportMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorEDIMapping> DIO_VendorEDIMapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorFreight> DIO_VendorFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorMarkForStore> DIO_VendorMarkForStore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorShippingInfo> DIO_VendorShippingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorStatement> DIO_VendorStatement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockIn> DIO_WHStockIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTShipmentAdviceHeader> DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_MasterLocation> DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_POHeader> DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_VendorItem> DIS_VendorItem { get; set; }
    }
}
