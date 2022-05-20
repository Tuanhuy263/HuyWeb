namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_InventoryAdviceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_InventoryAdviceHeader()
        {
            DIO_InventoryAdviceDetail = new HashSet<DIO_InventoryAdviceDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int InventoryAdviceID { get; set; }

        [StringLength(25)]
        public string ReceiverID { get; set; }

        [StringLength(2)]
        public string TransactionCode { get; set; }

        [StringLength(2)]
        public string ReportCode { get; set; }

        [StringLength(30)]
        public string InventoryInquiryID { get; set; }

        public DateTime? InventoryInquiryDate { get; set; }

        [StringLength(22)]
        public string VendorID { get; set; }

        [StringLength(5)]
        public string CurrencyCode { get; set; }

        [StringLength(50)]
        public string InventoryInquiryTime { get; set; }

        [StringLength(50)]
        public string ActionCode { get; set; }

        [StringLength(50)]
        public string DepartmentCode { get; set; }

        [StringLength(50)]
        public string InternalVendorNumber { get; set; }

        [StringLength(50)]
        public string FactorCustomerID { get; set; }

        [StringLength(50)]
        public string FactorCustomerSubID { get; set; }

        [StringLength(50)]
        public string BatchNumber { get; set; }

        [StringLength(50)]
        public string MerchandiseType { get; set; }

        [StringLength(50)]
        public string ContractNumber { get; set; }

        [StringLength(50)]
        public string PromoNumber { get; set; }

        public DateTime? ShipDate { get; set; }

        public DateTime? ReportStartDate { get; set; }

        public DateTime? ReportEndDate { get; set; }

        [StringLength(255)]
        public string BillToName { get; set; }

        [StringLength(50)]
        public string BillToCodeType { get; set; }

        [StringLength(80)]
        public string BillToCode { get; set; }

        [StringLength(255)]
        public string BillToAddress1 { get; set; }

        [StringLength(255)]
        public string BillToAddress2 { get; set; }

        [StringLength(50)]
        public string BillToCity { get; set; }

        [StringLength(50)]
        public string BillToState { get; set; }

        [StringLength(15)]
        public string BillToZipcode { get; set; }

        [StringLength(50)]
        public string BillToCountry { get; set; }

        [StringLength(255)]
        public string BuyerContactName { get; set; }

        [StringLength(100)]
        public string BuyerContactPhone { get; set; }

        [StringLength(100)]
        public string BuyerContactEmail { get; set; }

        [StringLength(255)]
        public string VendorName { get; set; }

        [StringLength(80)]
        public string VendorNumber { get; set; }

        [StringLength(255)]
        public string ShipToName { get; set; }

        [StringLength(50)]
        public string ShipToCodeType { get; set; }

        [StringLength(80)]
        public string ShipToCode { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(255)]
        public string ShipToAddress2 { get; set; }

        [StringLength(50)]
        public string ShipToCity { get; set; }

        [StringLength(50)]
        public string ShipToState { get; set; }

        [StringLength(15)]
        public string ShipToZipcode { get; set; }

        [StringLength(50)]
        public string ShipToCountry { get; set; }

        public int? InventoryAdviceType { get; set; }

        public int? InventoryAdviceStatus { get; set; }

        public bool? IsExported { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? InventoryAdviceConfigID { get; set; }

        public int? WarehouseLevelID { get; set; }

        public int? OptimisticLockField { get; set; }

        [Column(TypeName = "money")]
        public decimal? HashTotal { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string WarehouseLevelCode { get; set; }

        [StringLength(100)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string SupplierId { get; set; }

        [StringLength(100)]
        public string SupplierCountry { get; set; }

        [StringLength(100)]
        public string WarehouseCode { get; set; }

        [StringLength(100)]
        public string WarehouseQualifier { get; set; }

        [StringLength(100)]
        public string WarehouseName { get; set; }

        [StringLength(100)]
        public string DepositorCode { get; set; }

        [StringLength(100)]
        public string DepositorQualifier { get; set; }

        [StringLength(100)]
        public string DepositorName { get; set; }

        [StringLength(255)]
        public string SellingPartyName { get; set; }

        [StringLength(100)]
        public string SellingPartyQualifier { get; set; }

        [StringLength(80)]
        public string SellingPartyCode { get; set; }

        [StringLength(255)]
        public string SellingPartyAddress1 { get; set; }

        [StringLength(255)]
        public string SellingPartyAddress2 { get; set; }

        [StringLength(50)]
        public string SellingPartyCity { get; set; }

        [StringLength(50)]
        public string SellingPartyState { get; set; }

        [StringLength(15)]
        public string SellingPartyZipcode { get; set; }

        [StringLength(50)]
        public string SellingPartyCountry { get; set; }

        public bool? IsUpdatedInventory { get; set; }

        [StringLength(50)]
        public string MasterLocationCode { get; set; }

        [StringLength(255)]
        public string StoreProcedureNonEDI { get; set; }

        public bool? IsExportToQB { get; set; }

        public bool? IsValid { get; set; }

        public virtual DIO_InventoryAdviceConfig DIO_InventoryAdviceConfig { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InventoryAdviceDetail> DIO_InventoryAdviceDetail { get; set; }
    }
}
