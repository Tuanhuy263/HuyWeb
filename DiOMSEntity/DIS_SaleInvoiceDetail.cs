namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_SaleInvoiceDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_SaleInvoiceDetail()
        {
            DIO_ASNInvoiceDetail = new HashSet<DIO_ASNInvoiceDetail>();
            DIO_SaleInvoiceBatch = new HashSet<DIO_SaleInvoiceBatch>();
            DIO_SaleInvoiceSerial = new HashSet<DIO_SaleInvoiceSerial>();
            DIO_SISODetail = new HashSet<DIO_SISODetail>();
            DIO_SOInvoiceDetailAllowanceCharge = new HashSet<DIO_SOInvoiceDetailAllowanceCharge>();
            DIO_SubLineItem = new HashSet<DIO_SubLineItem>();
        }

        [Key]
        public int SaleInvoiceDetailNo { get; set; }

        public int SaleInvoiceNo { get; set; }

        public int LnNo { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? UOMCode { get; set; }

        public decimal? UOMRate { get; set; }

        public int MasterItemID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(3)]
        public string BasicUnitPrice { get; set; }

        public decimal? UnitCost { get; set; }

        public decimal? Amount { get; set; }

        public byte? Status { get; set; }

        public int? TaxID { get; set; }

        public decimal? TaxRate { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? TaxAfterDiscountAmount { get; set; }

        public int? DiscountID { get; set; }

        public decimal? DiscountAmount { get; set; }

        public decimal? DiscountRate { get; set; }

        public decimal? ReceiveWithoutUnReceipt { get; set; }

        public int? MasterLocationID { get; set; }

        [StringLength(255)]
        public string QBSIDetailNo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(255)]
        public string QBSIDetailDiscountNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemQty { get; set; }

        public int? IndividualItemID { get; set; }

        public int? UOMID { get; set; }

        [StringLength(50)]
        public string ShipmentStatusCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDifference { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExtendLineAmount { get; set; }

        [StringLength(255)]
        public string UserDefined102 { get; set; }

        [StringLength(255)]
        public string UserDefined196 { get; set; }

        [StringLength(255)]
        public string UserDefined197 { get; set; }

        [StringLength(255)]
        public string UserDefined226 { get; set; }

        [StringLength(255)]
        public string UserDefined227 { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAllowance { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCharge { get; set; }

        public int? SaleOrderDetailID { get; set; }

        public int? WarehouseID { get; set; }

        public int? BinID { get; set; }

        public int? UOMSetID { get; set; }

        public int? PriceChangeNoteID { get; set; }

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
        public virtual ICollection<DIO_ASNInvoiceDetail> DIO_ASNInvoiceDetail { get; set; }

        public virtual DIO_Discount DIO_Discount { get; set; }

        public virtual DIO_PriceChangeNote DIO_PriceChangeNote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SaleInvoiceBatch> DIO_SaleInvoiceBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SaleInvoiceSerial> DIO_SaleInvoiceSerial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SISODetail> DIO_SISODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SOInvoiceDetailAllowanceCharge> DIO_SOInvoiceDetailAllowanceCharge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SubLineItem> DIO_SubLineItem { get; set; }

        public virtual DIO_Tax DIO_Tax { get; set; }

        public virtual DIO_UOMSet DIO_UOMSet { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem1 { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation1 { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_SaleInvoiceHeader DIS_SaleInvoiceHeader { get; set; }
    }
}
