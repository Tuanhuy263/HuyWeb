namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHSTRawReceiptAdviceLineItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHSTRawReceiptAdviceLineItem()
        {
            DIO_WHSTRawReceiptAdviceLineItemBatch = new HashSet<DIO_WHSTRawReceiptAdviceLineItemBatch>();
            DIO_WHSTRawReceiptAdviceLineItemSerial = new HashSet<DIO_WHSTRawReceiptAdviceLineItemSerial>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHSTRawReceiptAdviceLineItemID { get; set; }

        [StringLength(100)]
        public string PONumber { get; set; }

        [StringLength(100)]
        public string ItemQuantityReceived { get; set; }

        [StringLength(100)]
        public string UnitType { get; set; }

        [StringLength(100)]
        public string UPCCaseCode { get; set; }

        [StringLength(100)]
        public string ProductCodeQual1 { get; set; }

        [StringLength(100)]
        public string productCode1 { get; set; }

        [StringLength(100)]
        public string ProductCodeQual2 { get; set; }

        [StringLength(100)]
        public string ProductCode2 { get; set; }

        [StringLength(100)]
        public string ItemDescription { get; set; }

        [StringLength(100)]
        public string WarehouseitemLotNumber { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo1 { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo2 { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo3 { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo4 { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo5 { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo6 { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo7 { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo8 { get; set; }

        [StringLength(100)]
        public string ItemAdditionalinfo9 { get; set; }

        [StringLength(100)]
        public string TotalUnitsShipped { get; set; }

        [StringLength(100)]
        public string TotalQuantityReceived { get; set; }

        [StringLength(100)]
        public string QuantityDamaged_OnHold { get; set; }

        [StringLength(100)]
        public string SummaryAdditionalinfo1 { get; set; }

        [StringLength(100)]
        public string SummaryAdditionalinfo2 { get; set; }

        [StringLength(100)]
        public string SummaryAdditionalinfo3 { get; set; }

        [StringLength(100)]
        public string SummaryAdditionalinfo4 { get; set; }

        [StringLength(100)]
        public string SummaryAdditionalinfo5 { get; set; }

        [StringLength(100)]
        public string ContainerID { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamaged { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamagedUnitType { get; set; }

        [StringLength(100)]
        public string ReceivingConditionCode { get; set; }

        [StringLength(100)]
        public string WarehouseContainerLotNo { get; set; }

        [StringLength(100)]
        public string DamageReasonCode { get; set; }

        [StringLength(100)]
        public string ContainerAdditionalinfo1 { get; set; }

        [StringLength(100)]
        public string ContainerAdditionalinfo2 { get; set; }

        [StringLength(100)]
        public string ContainerAdditionalinfo3 { get; set; }

        [StringLength(100)]
        public string ContainerAdditionalinfo4 { get; set; }

        [StringLength(100)]
        public string ContainerAdditionalinfo5 { get; set; }

        [StringLength(100)]
        public string LotNo1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyshippedfortheLot_1 { get; set; }

        [StringLength(100)]
        public string BestByDateforItem1 { get; set; }

        [StringLength(100)]
        public string Lot1AdditionalInfo1 { get; set; }

        [StringLength(100)]
        public string Lot1AdditionalInfo2 { get; set; }

        [StringLength(100)]
        public string Lot1AdditionalInfo3 { get; set; }

        [StringLength(100)]
        public string Lot1AdditionalInfo4 { get; set; }

        [StringLength(100)]
        public string Lot1AdditionalInfo5 { get; set; }

        [StringLength(100)]
        public string LotNo2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyshippedfortheLot_2 { get; set; }

        [StringLength(100)]
        public string BestByDateforItem2 { get; set; }

        [StringLength(100)]
        public string Lot2AdditionalInfo1 { get; set; }

        [StringLength(100)]
        public string Lot2AdditionalInfo2 { get; set; }

        [StringLength(100)]
        public string Lot2AdditionalInfo3 { get; set; }

        [StringLength(100)]
        public string Lot2AdditionalInfo4 { get; set; }

        [StringLength(100)]
        public string Lot2AdditionalInfo5 { get; set; }

        [StringLength(100)]
        public string LotNo3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyshippedfortheLot_3 { get; set; }

        [StringLength(100)]
        public string BestByDateforItem3 { get; set; }

        [StringLength(100)]
        public string Lot3AdditionalInfo1 { get; set; }

        [StringLength(100)]
        public string Lot3AdditionalInfo2 { get; set; }

        [StringLength(100)]
        public string Lot3AdditionalInfo3 { get; set; }

        [StringLength(100)]
        public string Lot3AdditionalInfo4 { get; set; }

        [StringLength(100)]
        public string Lot3AdditionalInfo5 { get; set; }

        [StringLength(100)]
        public string LotNo4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyshippedfortheLot_4 { get; set; }

        [StringLength(100)]
        public string BestByDateforItem4 { get; set; }

        [StringLength(100)]
        public string Lot4AdditionalInfo1 { get; set; }

        [StringLength(100)]
        public string Lot4AdditionalInfo2 { get; set; }

        [StringLength(100)]
        public string Lot4AdditionalInfo3 { get; set; }

        [StringLength(100)]
        public string Lot4AdditionalInfo4 { get; set; }

        [StringLength(100)]
        public string Lot4AdditionalInfo5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamaged1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamagedUnitType1 { get; set; }

        [StringLength(100)]
        public string ReceivingConditionCode1 { get; set; }

        [StringLength(100)]
        public string DamagedLotNo1 { get; set; }

        [StringLength(100)]
        public string DamageReasonCode1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamaged2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamagedUnitType2 { get; set; }

        [StringLength(100)]
        public string ReceivingConditionCode2 { get; set; }

        [StringLength(100)]
        public string DamagedLotNo2 { get; set; }

        [StringLength(100)]
        public string DamageReasonCode2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamaged3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamagedUnitType3 { get; set; }

        [StringLength(100)]
        public string ReceivingConditionCode3 { get; set; }

        [StringLength(100)]
        public string DamagedLotNo3 { get; set; }

        [StringLength(100)]
        public string DamageReasonCode3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamaged4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamagedUnitType4 { get; set; }

        [StringLength(100)]
        public string ReceivingConditionCode4 { get; set; }

        [StringLength(100)]
        public string DamagedLotNo4 { get; set; }

        [StringLength(100)]
        public string DamageReasonCode4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamaged5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? QtyDamagedUnitType5 { get; set; }

        [StringLength(100)]
        public string ReceivingConditionCode5 { get; set; }

        [StringLength(100)]
        public string DamagedLotNo5 { get; set; }

        [StringLength(100)]
        public string DamageReasonCode5 { get; set; }

        public int? WHSTRawReceiptAdviceHeaderID { get; set; }

        public int? WHSTRawReceiptAdviceCartonID { get; set; }

        public int? WHSTRawReceiptAdvicePalletID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? IsValidData { get; set; }

        public bool? IsIgnored { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        public int? MasterItem { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack { get; set; }

        [Column(TypeName = "money")]
        public decimal? InnerPack { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cartons { get; set; }

        [StringLength(100)]
        public string ItemCode { get; set; }

        [StringLength(100)]
        public string InventoryStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineItemNumbers { get; set; }

        public DateTime? ProductReceiptDate { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(100)]
        public string ProductCode3 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(100)]
        public string ProductCode4 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(100)]
        public string ProductCode5 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(100)]
        public string ProductCode6 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(100)]
        public string ProductCode7 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(100)]
        public string ProductCode8 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(100)]
        public string ProductCode9 { get; set; }

        [StringLength(100)]
        public string ProductCodeQualifier10 { get; set; }

        [StringLength(100)]
        public string ProductCode10 { get; set; }

        public virtual DIO_WHSTRawReceiptAdviceCarton DIO_WHSTRawReceiptAdviceCarton { get; set; }

        public virtual DIO_WHSTRawReceiptAdviceHeader DIO_WHSTRawReceiptAdviceHeader { get; set; }

        public virtual DIO_WHSTRawReceiptAdvicePallet DIO_WHSTRawReceiptAdvicePallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHSTRawReceiptAdviceLineItemBatch> DIO_WHSTRawReceiptAdviceLineItemBatch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHSTRawReceiptAdviceLineItemSerial> DIO_WHSTRawReceiptAdviceLineItemSerial { get; set; }
    }
}
