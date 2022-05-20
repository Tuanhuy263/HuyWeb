namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_PurchaseInvoiceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_PurchaseInvoiceHeader()
        {
            DIO_InvoicePOFreight = new HashSet<DIO_InvoicePOFreight>();
            DIO_PIDeposit = new HashSet<DIO_PIDeposit>();
            DIO_POInvoiceHeaderAllowanceCharge = new HashSet<DIO_POInvoiceHeaderAllowanceCharge>();
            DIO_POPIHeader = new HashSet<DIO_POPIHeader>();
            DIO_VendorPaymentDetail = new HashSet<DIO_VendorPaymentDetail>();
            DIO_WSTReceiptAdviceHeader = new HashSet<DIO_WSTReceiptAdviceHeader>();
            DIS_ASN = new HashSet<DIS_ASN>();
            DIS_PurchaseInvoiceDetail = new HashSet<DIS_PurchaseInvoiceDetail>();
        }

        [Key]
        public int PurchaseInvoiceNo { get; set; }

        [Required]
        [StringLength(255)]
        public string PurchaseInvoiceNumber { get; set; }

        public int PONo { get; set; }

        public int? WHStockInNo { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime ReceivedDate { get; set; }

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

        [StringLength(255)]
        public string QBPINo { get; set; }

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

        public int? FlagID { get; set; }

        public int? BillToCode { get; set; }

        public int? ShipFromCode { get; set; }

        public int? ShipToID { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [StringLength(255)]
        public string EDIPurchaseInvoiceNumber { get; set; }

        public int? TransportationProviderID { get; set; }

        public int? TransportationMethodID { get; set; }

        public bool? NeedToSyncToQB { get; set; }

        public bool? CreatedSI { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowanceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalChargeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscountAmount { get; set; }

        public int? ASNNo { get; set; }

        public long? TraceStatus { get; set; }

        public int? WarehouseReceiptAdviceID { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDeposit { get; set; }

        public int? WarehouseShipmentAdviceID { get; set; }

        public virtual DIO_Currency DIO_Currency { get; set; }

        public virtual DIO_ERP_Term DIO_ERP_Term { get; set; }

        public virtual DIO_Flag DIO_Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_InvoicePOFreight> DIO_InvoicePOFreight { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PIDeposit> DIO_PIDeposit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POInvoiceHeaderAllowanceCharge> DIO_POInvoiceHeaderAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_POPIHeader> DIO_POPIHeader { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo3 { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIO_TermBasisDate DIO_TermBasisDate { get; set; }

        public virtual DIO_TermsType DIO_TermsType { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorPaymentDetail> DIO_VendorPaymentDetail { get; set; }

        public virtual DIO_WHStockIn DIO_WHStockIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceHeader> DIO_WSTReceiptAdviceHeader { get; set; }

        public virtual DIO_WSTReceiptAdviceHeader DIO_WSTReceiptAdviceHeader1 { get; set; }

        public virtual DIO_WSTShipmentAdviceHeader DIO_WSTShipmentAdviceHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_ASN> DIS_ASN { get; set; }

        public virtual DIS_ASN DIS_ASN1 { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_PurchaseInvoiceDetail> DIS_PurchaseInvoiceDetail { get; set; }
    }
}
