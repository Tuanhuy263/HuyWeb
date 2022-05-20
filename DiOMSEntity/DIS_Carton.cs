namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_Carton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIS_Carton()
        {
            DIO_PackDetail = new HashSet<DIO_PackDetail>();
            DIS_LineItem = new HashSet<DIS_LineItem>();
            DIS_LineItem1 = new HashSet<DIS_LineItem>();
            DIS_CartonTransaction = new HashSet<DIS_CartonTransaction>();
            DIS_LineItem2 = new HashSet<DIS_LineItem>();
        }

        [Key]
        public int CartonNo { get; set; }

        public int? SONo { get; set; }

        public int? ASNPONo { get; set; }

        public int? ASNSONo { get; set; }

        public int? ASNPOPalletNo { get; set; }

        public int? ASNSOPalletNo { get; set; }

        [StringLength(150)]
        public string ContainerQualifer { get; set; }

        [StringLength(150)]
        public string ContainerCode { get; set; }

        public int? SequenceNumber { get; set; }

        [StringLength(150)]
        public string TransactionNumber { get; set; }

        [StringLength(150)]
        public string PackageType { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Volume { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(30)]
        public string Optional1 { get; set; }

        [StringLength(30)]
        public string Optional2 { get; set; }

        [StringLength(30)]
        public string Optional3 { get; set; }

        [StringLength(30)]
        public string Optional4 { get; set; }

        [StringLength(30)]
        public string Optional5 { get; set; }

        public decimal? FreightCharges { get; set; }

        public decimal? HandlingCharges { get; set; }

        public int? Status { get; set; }

        public int? ObjectType { get; set; }

        public bool? IsVerify { get; set; }

        public int? PTSCartonNo { get; set; }

        public bool? IsPacked { get; set; }

        public bool? IsPicked { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsPrintUCCLabel { get; set; }

        [StringLength(255)]
        public string UserPrint { get; set; }

        public DateTime? PrintDate { get; set; }

        [StringLength(255)]
        public string CartonLocation { get; set; }

        public DateTime? ReplicationDate { get; set; }

        [StringLength(48)]
        public string OriginalContainerCode { get; set; }

        public int? WeightCode { get; set; }

        public int? VolumeCode { get; set; }

        [StringLength(255)]
        public string UserPack { get; set; }

        public int? PackedUserID { get; set; }

        public int? WSTShipmentAdviceDetailID { get; set; }

        public int? WSTShipmentAdvicePalletID { get; set; }

        public int? ShipmentAdviceHeaderId { get; set; }

        public int? ShipmentAdvicePalletPoId { get; set; }

        public int? PONo { get; set; }

        [StringLength(150)]
        public string SSC14 { get; set; }

        public byte[] BarcodeImage { get; set; }

        [StringLength(250)]
        public string TrackingNo { get; set; }

        [StringLength(255)]
        public string BarcodeUrl { get; set; }

        [Column("_CartonCode")]
        [StringLength(100)]
        public string C_CartonCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Height { get; set; }

        public int? MasterLocation { get; set; }

        [Column(TypeName = "money")]
        public decimal? NumberOfUnits { get; set; }

        [StringLength(255)]
        public string ShipmentIDByCarrier { get; set; }

        [StringLength(500)]
        public string UPS_Status_Type_Description { get; set; }

        public byte? UPS_Status_Type { get; set; }

        public byte? UPS_Status_Type_Code { get; set; }

        public byte[] OriBarcodeImage { get; set; }

        [StringLength(500)]
        public string Fedex_Status_Track_Description { get; set; }

        [StringLength(10)]
        public string Fedex_Status_Track_Code { get; set; }

        [StringLength(20)]
        public string TrackingStatusCode { get; set; }

        [StringLength(500)]
        public string TrackingStatusDescription { get; set; }

        public DateTime? ActualDelivery { get; set; }

        public DateTime? ActualPickup { get; set; }

        public DateTime? Ship { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackDetail> DIO_PackDetail { get; set; }

        public virtual DIO_PTSCarton DIO_PTSCarton { get; set; }

        public virtual DIS_ASNPO DIS_ASNPO { get; set; }

        public virtual DIS_ASNPOPallet DIS_ASNPOPallet { get; set; }

        public virtual DIS_ASNSO DIS_ASNSO { get; set; }

        public virtual DIS_ASNSOPallet DIS_ASNSOPallet { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIS_User DIS_User { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_LineItem> DIS_LineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_LineItem> DIS_LineItem1 { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_CartonTransaction> DIS_CartonTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_LineItem> DIS_LineItem2 { get; set; }
    }
}
