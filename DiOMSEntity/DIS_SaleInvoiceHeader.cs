namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_SaleInvoiceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_SaleInvoiceHeader()
        {
            DIO_ASNInvoice = new HashSet<DIO_ASNInvoice>();
            DIO_BrokerPayment = new HashSet<DIO_BrokerPayment>();
            DIO_CustomerPaymentDetail = new HashSet<DIO_CustomerPaymentDetail>();
            DIO_InvoiceSOFreight = new HashSet<DIO_InvoiceSOFreight>();
            DIO_SISOHeader = new HashSet<DIO_SISOHeader>();
            DIO_SOInvoiceHeaderAllowanceCharge = new HashSet<DIO_SOInvoiceHeaderAllowanceCharge>();
            DIS_SaleInvoiceDetail = new HashSet<DIS_SaleInvoiceDetail>();
            DIS_SaleInvoiceHeader1 = new HashSet<DIS_SaleInvoiceHeader>();
            DIS_SISO = new HashSet<DIS_SISO>();
        }

        [Key]
        public int SaleInvoiceNo { get; set; }

        [Required]
        [StringLength(200)]
        public string SaleInvoiceNumber { get; set; }

        public int SONo { get; set; }

        public int? RemitTo { get; set; }

        public int? ShipTo { get; set; }

        public int? BillTo { get; set; }

        public int? WHStockOutNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public DateTime? DueDate { get; set; }

        public int? CurrencyCode { get; set; }

        public decimal? ExchangeRateAmount { get; set; }

        public byte? Status { get; set; }

        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? TotalBeforeDiscount { get; set; }

        public decimal? TotalPaymentDue { get; set; }

        public decimal? TotalPaymentAmount { get; set; }

        public decimal? DueDateCalculation { get; set; }

        public int? TermBasisDateID { get; set; }

        public int? TermTypeID { get; set; }

        public DateTime? TermDiscDueDate { get; set; }

        public decimal? TermDiscPercent { get; set; }

        public decimal? TermDiscDayDue { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        public decimal? TermDiscAmount { get; set; }

        public bool? IsFactored { get; set; }

        [StringLength(255)]
        public string QBSINo { get; set; }

        public int? ASNSONo { get; set; }

        public bool? IsSent { get; set; }

        public int? FOBPaymentID { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsFixTax { get; set; }

        public DateTime? QBDateModified { get; set; }

        public int? ERPTermID { get; set; }

        public int? FixTaxID { get; set; }

        public int? QBClassID { get; set; }

        public int? FlagID { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        public int? TransportationProviderID { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        public int? InvoiceTypeID { get; set; }

        public int? TransportationMethodID { get; set; }

        public bool? ConsolidateStatus { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        public int? MasterSI { get; set; }

        public string CombinedSaleInvoiceNumber { get; set; }

        public int? SaleRequirementID { get; set; }

        public int? SpecialHandlingID { get; set; }

        [StringLength(100)]
        public string DepartmentName { get; set; }

        [StringLength(50)]
        public string GSTCode { get; set; }

        [StringLength(255)]
        public string GSTDescription { get; set; }

        [StringLength(50)]
        public string PSTCode { get; set; }

        [StringLength(255)]
        public string PSTDescription { get; set; }

        [StringLength(255)]
        public string InfoContactName { get; set; }

        [StringLength(50)]
        public string InfoContactTel { get; set; }

        [StringLength(250)]
        public string OrderByContactFax { get; set; }

        [StringLength(60)]
        public string OrderByContactFirstName { get; set; }

        [StringLength(60)]
        public string OrderByContactLastName { get; set; }

        [StringLength(80)]
        public string OrderByContactPhone { get; set; }

        [StringLength(100)]
        public string OrderByContactEmail { get; set; }

        [StringLength(255)]
        public string ServiceTechnicianName { get; set; }

        [StringLength(255)]
        public string ServiceTechnicianTel { get; set; }

        public string Message { get; set; }

        public bool? UploadEDI { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        public int? ShipFrom { get; set; }

        public byte? Type { get; set; }

        [StringLength(250)]
        public string FOBDescription { get; set; }

        public int? DiscType { get; set; }

        public int? TermDiscType { get; set; }

        public int? LocationQualifierID { get; set; }

        [StringLength(255)]
        public string EDISONumber { get; set; }

        [StringLength(255)]
        public string SOOriginalNumber { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        public bool? IsCombineSI { get; set; }

        public int? AssignWarehouseID { get; set; }

        public int? CalculateChargeTypeTax { get; set; }

        [StringLength(255)]
        public string ExternalSINumber { get; set; }

        public long? SITraceStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmountHeader { get; set; }

        public bool? HasDiscountAmountHeader { get; set; }

        [StringLength(255)]
        public string QBIDOfDiscountAmountHeader { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalFreight { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTaxAmount { get; set; }

        [StringLength(255)]
        public string QBIDSO { get; set; }

        [StringLength(255)]
        public string QBOnlineID { get; set; }

        [StringLength(100)]
        public string MemDeliver { get; set; }

        [StringLength(100)]
        public string MemPayment { get; set; }

        [StringLength(100)]
        public string QBTotalAllowanceDiscountID { get; set; }

        [StringLength(100)]
        public string QBTotalFreightID { get; set; }

        [StringLength(50)]
        public string CustomField_String50_1 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_2 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_3 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_4 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_5 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_6 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_7 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_8 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_9 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_10 { get; set; }

        public bool? CustomField_Bool_1 { get; set; }

        public bool? CustomField_Bool_2 { get; set; }

        public bool? CustomField_Bool_3 { get; set; }

        public bool? CustomField_Bool_4 { get; set; }

        public bool? CustomField_Bool_5 { get; set; }

        public bool? CustomField_Bool_6 { get; set; }

        public bool? CustomField_Bool_7 { get; set; }

        public bool? CustomField_Bool_8 { get; set; }

        public bool? CustomField_Bool_9 { get; set; }

        public bool? CustomField_Bool_10 { get; set; }

        public DateTime? CustomField_DateTime_1 { get; set; }

        public DateTime? CustomField_DateTime_2 { get; set; }

        public DateTime? CustomField_DateTime_3 { get; set; }

        public DateTime? CustomField_DateTime_4 { get; set; }

        public DateTime? CustomField_DateTime_5 { get; set; }

        public DateTime? CustomField_DateTime_6 { get; set; }

        public DateTime? CustomField_DateTime_7 { get; set; }

        public DateTime? CustomField_DateTime_8 { get; set; }

        public DateTime? CustomField_DateTime_9 { get; set; }

        public DateTime? CustomField_DateTime_10 { get; set; }

        public int? CustomField_Int_1 { get; set; }

        public int? CustomField_Int_2 { get; set; }

        public int? CustomField_Int_3 { get; set; }

        public int? CustomField_Int_4 { get; set; }

        public int? CustomField_Int_5 { get; set; }

        public int? CustomField_Int_6 { get; set; }

        public int? CustomField_Int_7 { get; set; }

        public int? CustomField_Int_8 { get; set; }

        public int? CustomField_Int_9 { get; set; }

        public int? CustomField_Int_10 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_1 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_2 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_3 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_4 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_5 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_6 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_7 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_8 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_9 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_10 { get; set; }

        public long? CustomField_Long_1 { get; set; }

        public long? CustomField_Long_2 { get; set; }

        public long? CustomField_Long_3 { get; set; }

        public long? CustomField_Long_4 { get; set; }

        public long? CustomField_Long_5 { get; set; }

        public long? CustomField_Long_6 { get; set; }

        public long? CustomField_Long_7 { get; set; }

        public long? CustomField_Long_8 { get; set; }

        public long? CustomField_Long_9 { get; set; }

        public long? CustomField_Long_10 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ASNInvoice> DIO_ASNInvoice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_BrokerPayment> DIO_BrokerPayment { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerPaymentDetail> DIO_CustomerPaymentDetail { get; set; }

        public virtual DIO_ERP_Term DIO_ERP_Term { get; set; }

        public virtual DIO_Flag DIO_Flag { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InvoiceSOFreight> DIO_InvoiceSOFreight { get; set; }

        public virtual DIO_InvoiceType DIO_InvoiceType { get; set; }

        public virtual DIO_LocationQualifier DIO_LocationQualifier { get; set; }

        public virtual DIO_QBClass DIO_QBClass { get; set; }

        public virtual DIO_SaleRequirement DIO_SaleRequirement { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SISOHeader> DIO_SISOHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOInvoiceHeaderAllowanceCharge> DIO_SOInvoiceHeaderAllowanceCharge { get; set; }

        public virtual DIO_SpecialHandling DIO_SpecialHandling { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIO_TermBasisDate DIO_TermBasisDate { get; set; }

        public virtual DIO_TermsType DIO_TermsType { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIO_WHStockOut DIO_WHStockOut { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceDetail> DIS_SaleInvoiceDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SaleInvoiceHeader> DIS_SaleInvoiceHeader1 { get; set; }

        public virtual DIS_SaleInvoiceHeader DIS_SaleInvoiceHeader2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SISO> DIS_SISO { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }
    }
}
