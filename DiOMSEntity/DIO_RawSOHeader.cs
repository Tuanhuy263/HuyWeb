namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawSOHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawSOHeader()
        {
            DIO_RawSODetail = new HashSet<DIO_RawSODetail>();
        }

        [Key]
        public int RawSOHeaderId { get; set; }

        [StringLength(20)]
        public string TransactionControlNo { get; set; }

        [StringLength(10)]
        public string TransType { get; set; }

        [StringLength(30)]
        public string SOTransactionPurposeCode { get; set; }

        [StringLength(255)]
        public string SONumber { get; set; }

        public DateTime? SODate { get; set; }

        [StringLength(20)]
        public string DepartmentNo { get; set; }

        [StringLength(250)]
        public string ProductGroupDescription { get; set; }

        [StringLength(250)]
        public string FutureUse7 { get; set; }

        [StringLength(50)]
        public string HubSenderID { get; set; }

        [StringLength(50)]
        public string InternalVendorNo { get; set; }

        [StringLength(250)]
        public string VendorName { get; set; }

        [StringLength(250)]
        public string PromotionCode { get; set; }

        [StringLength(250)]
        public string GuestName { get; set; }

        public string GuestContactInfo { get; set; }

        [StringLength(250)]
        public string FOBMethodOfPayment { get; set; }

        [StringLength(250)]
        public string FOBPoint { get; set; }

        [StringLength(250)]
        public string FOBDescription { get; set; }

        [StringLength(20)]
        public string SaleRequirementCode { get; set; }

        [StringLength(250)]
        public string OriginalReferenceNo { get; set; }

        [StringLength(250)]
        public string ContractNo { get; set; }

        public string Message { get; set; }

        [StringLength(250)]
        public string SaleRequirement { get; set; }

        public DateTime? SOChangeDate { get; set; }

        [StringLength(20)]
        public string CurrencyCode { get; set; }

        public decimal? TermDiscountAmount { get; set; }

        [StringLength(255)]
        public string VendorNo { get; set; }

        [StringLength(255)]
        public string SpecialTicketType { get; set; }

        [StringLength(255)]
        public string SpecialOrderType { get; set; }

        [StringLength(255)]
        public string TermsTypeCode { get; set; }

        [StringLength(255)]
        public string TermsBasisDateType { get; set; }

        public decimal? TermDiscPercent { get; set; }

        public decimal? TermDiscDaysDue { get; set; }

        [StringLength(250)]
        public string TermDescription { get; set; }

        public int? TermsNetDays { get; set; }

        public DateTime? TermsNetDueDate { get; set; }

        public DateTime? TermsDiscountDueDate { get; set; }

        public decimal? TermDayOfMonth { get; set; }

        public DateTime? ShipNotBeforeDate { get; set; }

        public DateTime? ShipNotAfterDate { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        [StringLength(30)]
        public string RoutingCodeType { get; set; }

        [StringLength(50)]
        public string TransportTypeCode { get; set; }

        [StringLength(250)]
        public string ShipToLocation { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator6 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode6 { get; set; }

        public decimal? AllowanceOrChargeAmount6 { get; set; }

        public decimal? AllowancePercent6 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling6 { get; set; }

        [StringLength(250)]
        public string ShipToName { get; set; }

        [StringLength(250)]
        public string ShipToAdress2 { get; set; }

        [StringLength(250)]
        public string ShipToAdress1 { get; set; }

        [StringLength(250)]
        public string ShipToCity { get; set; }

        [StringLength(250)]
        public string ShipToState { get; set; }

        [StringLength(250)]
        public string ShipToZipCode { get; set; }

        [StringLength(20)]
        public string ShipFromCode { get; set; }

        [StringLength(250)]
        public string ShipFromName { get; set; }

        [StringLength(250)]
        public string ShipFromAddress1 { get; set; }

        [StringLength(250)]
        public string ShipFromAddress2 { get; set; }

        [StringLength(250)]
        public string ShipFromCity { get; set; }

        [StringLength(20)]
        public string ShipFromState { get; set; }

        [StringLength(20)]
        public string ShipFromZipCode { get; set; }

        [StringLength(250)]
        public string ShipFormCountry { get; set; }

        [StringLength(250)]
        public string OrderedByContactFirstName { get; set; }

        [StringLength(250)]
        public string OrderedByContactLastName { get; set; }

        [StringLength(30)]
        public string OrderedByContactPhone { get; set; }

        [StringLength(250)]
        public string OrderedByContactEmail { get; set; }

        [StringLength(250)]
        public string OrderedByName { get; set; }

        [StringLength(250)]
        public string OrderedByAddress1 { get; set; }

        [StringLength(250)]
        public string OrderedByAddress2 { get; set; }

        [StringLength(250)]
        public string OrderedByCity { get; set; }

        [StringLength(20)]
        public string OrderedByState { get; set; }

        [StringLength(20)]
        public string OrderedByZipCode { get; set; }

        [StringLength(250)]
        public string OrderedByCountry { get; set; }

        [StringLength(250)]
        public string BillToName { get; set; }

        [StringLength(50)]
        public string BillToCode { get; set; }

        [StringLength(250)]
        public string BillToAddress { get; set; }

        [StringLength(250)]
        public string BillToCity { get; set; }

        [StringLength(20)]
        public string BillToState { get; set; }

        [StringLength(20)]
        public string BillToZipCode { get; set; }

        [StringLength(250)]
        public string BillToCountry { get; set; }

        public int? NumberOfLineItem { get; set; }

        public decimal? TotalOrderQty { get; set; }

        public decimal? TotalOrderAmount { get; set; }

        [StringLength(50)]
        public string MerchandiseCode { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator1 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode1 { get; set; }

        public decimal? AllowanceOrChargeAmount1 { get; set; }

        public decimal? AllowancePercent1 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling1 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator2 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode2 { get; set; }

        public decimal? AllowanceOrChargeAmount2 { get; set; }

        public decimal? AllowancePercent2 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling2 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator3 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode3 { get; set; }

        public decimal? AllowanceOrChargeAmount3 { get; set; }

        public decimal? AllowancePercent3 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling3 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator4 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode4 { get; set; }

        public decimal? AllowanceOrChargeAmount4 { get; set; }

        public decimal? AllowancePercent4 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling4 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator5 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode5 { get; set; }

        public decimal? AllowanceOrChargeAmount5 { get; set; }

        public decimal? AllowancePercent5 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling5 { get; set; }

        [StringLength(250)]
        public string FutureUse159 { get; set; }

        [StringLength(20)]
        public string InvoiceType { get; set; }

        [StringLength(250)]
        public string FutureUse161 { get; set; }

        [StringLength(250)]
        public string FutureUse162 { get; set; }

        [StringLength(250)]
        public string FutureUse163 { get; set; }

        public int? InvalidRawSOType { get; set; }

        public int RawType { get; set; }

        public bool IsGeneratePO { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte? Status { get; set; }

        public DateTime? StartShipDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(250)]
        public string BuyerCode { get; set; }

        [StringLength(250)]
        public string FowarderName { get; set; }

        [StringLength(250)]
        public string SupplierCode { get; set; }

        [StringLength(250)]
        public string ShipToQualifier { get; set; }

        [StringLength(255)]
        public string EDISONumber { get; set; }

        [StringLength(255)]
        public string SpecialHandlingNote { get; set; }

        [StringLength(250)]
        public string ShipFromQualifier { get; set; }

        [StringLength(250)]
        public string BillToQualifier { get; set; }

        [StringLength(100)]
        public string BuyerQualifier { get; set; }

        [StringLength(100)]
        public string BuyerName { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription6 { get; set; }

        [StringLength(255)]
        public string UserDefined73 { get; set; }

        [StringLength(255)]
        public string UserDefined74 { get; set; }

        public DateTime? ScheduleShipDate { get; set; }

        [StringLength(255)]
        public string ShipToFacility { get; set; }

        [StringLength(255)]
        public string GuestContactPhone { get; set; }

        [StringLength(255)]
        public string SCACCode { get; set; }

        [StringLength(255)]
        public string RoutingName { get; set; }

        [StringLength(250)]
        public string ShipToPhone { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription1 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription2 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription3 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription4 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription5 { get; set; }

        [StringLength(50)]
        public string ShippingMethod { get; set; }

        [StringLength(20)]
        public string OrderContactFax { get; set; }

        [StringLength(250)]
        public string InfoContactName { get; set; }

        [StringLength(30)]
        public string InfoContactTel { get; set; }

        [StringLength(250)]
        public string ServiceTechnicianName { get; set; }

        [StringLength(30)]
        public string ServiceTechnicianTel { get; set; }

        [StringLength(50)]
        public string BillToContactTel { get; set; }

        [StringLength(50)]
        public string BillToContactFax { get; set; }

        [StringLength(250)]
        public string BillToContactEmail { get; set; }

        [StringLength(250)]
        public string BillToAddress2 { get; set; }

        [StringLength(250)]
        public string ShipToAddName { get; set; }

        [StringLength(250)]
        public string ShipToCountry { get; set; }

        public DateTime? CancelAfterDate { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }

        [StringLength(100)]
        public string OrderType { get; set; }

        [StringLength(250)]
        public string WHCode { get; set; }

        [StringLength(250)]
        public string CommentType { get; set; }

        [StringLength(1000)]
        public string WHInstruction { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalTax { get; set; }

        [StringLength(20)]
        public string RemitToCode { get; set; }

        [StringLength(250)]
        public string RemitToName { get; set; }

        [StringLength(250)]
        public string RemitToAddress { get; set; }

        [StringLength(250)]
        public string RemitToCity { get; set; }

        [StringLength(20)]
        public string RemitToState { get; set; }

        [StringLength(20)]
        public string RemitToZipCode { get; set; }

        [StringLength(250)]
        public string RemitToCountry { get; set; }

        [StringLength(250)]
        public string RemitToQualifier { get; set; }

        [StringLength(4000)]
        public string FutureUse90 { get; set; }

        [StringLength(4000)]
        public string FutureUse91 { get; set; }

        [StringLength(4000)]
        public string FutureUse92 { get; set; }

        [StringLength(4000)]
        public string FutureUse93 { get; set; }

        [StringLength(4000)]
        public string FutureUse94 { get; set; }

        [StringLength(4000)]
        public string FutureUse95 { get; set; }

        [StringLength(4000)]
        public string FutureUse96 { get; set; }

        [StringLength(4000)]
        public string FutureUse97 { get; set; }

        [StringLength(4000)]
        public string FutureUse138 { get; set; }

        [StringLength(4000)]
        public string FutureUse139 { get; set; }

        [StringLength(4000)]
        public string FutureUse140 { get; set; }

        [StringLength(4000)]
        public string FutureUse141 { get; set; }

        [StringLength(4000)]
        public string FutureUse142 { get; set; }

        [StringLength(250)]
        public string TrackingNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPOWeight { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPOVolume { get; set; }

        [Column(TypeName = "money")]
        public decimal? GSTAmount { get; set; }

        [StringLength(250)]
        public string InvoiceGSTTaxID { get; set; }

        [Column(TypeName = "money")]
        public decimal? HSTTaxAmount { get; set; }

        [StringLength(250)]
        public string HSTTaxID { get; set; }

        [Column(TypeName = "money")]
        public decimal? FreightTax { get; set; }

        public int? NumberOfCartons { get; set; }

        [StringLength(250)]
        public string ShipToAdress3 { get; set; }

        [StringLength(250)]
        public string ShipToEmail { get; set; }

        [StringLength(250)]
        public string ShipToWeb { get; set; }

        [StringLength(250)]
        public string ShipToContact { get; set; }

        [StringLength(250)]
        public string ShipToFax { get; set; }

        [StringLength(250)]
        public string BillToAddress3 { get; set; }

        [StringLength(100)]
        public string BillToWeb { get; set; }

        [StringLength(100)]
        public string BillToContact { get; set; }

        [StringLength(250)]
        public string WarehouseCurrency { get; set; }

        [StringLength(250)]
        public string StorePONumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? WarehouseTax { get; set; }

        [StringLength(100)]
        public string WarehouseID { get; set; }

        [StringLength(250)]
        public string SeasonLinelistCode { get; set; }

        [StringLength(250)]
        public string CustomerGeneralNotes { get; set; }

        [StringLength(250)]
        public string CustomerWarehouseInstructions { get; set; }

        [StringLength(250)]
        public string CustomerShippingInstructions { get; set; }

        public DateTime? MustArriveDate { get; set; }

        [StringLength(255)]
        public string ItemDepartNo { get; set; }

        [StringLength(255)]
        public string ItemDepartName { get; set; }

        [StringLength(250)]
        public string BillToAddName { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator7 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent7 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling7 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator8 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent8 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling8 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator9 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent9 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling9 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeIndicator10 { get; set; }

        [StringLength(20)]
        public string AllowanceOrChargeCode10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowanceOrChargeAmount10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllowancePercent10 { get; set; }

        [StringLength(20)]
        public string AllowanceMethodOfHandling10 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription7 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription8 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription9 { get; set; }

        [StringLength(255)]
        public string AllowanceOrChargeDescription10 { get; set; }

        [StringLength(1000)]
        public string SpecialInstruction { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmountHeader { get; set; }

        [StringLength(250)]
        public string TaxCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        [StringLength(1000)]
        public string HubName { get; set; }

        [StringLength(250)]
        public string MarkForStoreNo { get; set; }

        [StringLength(4000)]
        public string FutureUse184 { get; set; }

        [StringLength(4000)]
        public string FutureUse189 { get; set; }

        [StringLength(255)]
        public string StrOrderDate { get; set; }

        [StringLength(255)]
        public string StrScheduleDate { get; set; }

        [StringLength(250)]
        public string RoyaltyCode { get; set; }

        [StringLength(250)]
        public string RoyaltyRate { get; set; }

        [StringLength(250)]
        public string ArtCode { get; set; }

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

        public byte? ECommerce { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawSODetail> DIO_RawSODetail { get; set; }
    }
}
