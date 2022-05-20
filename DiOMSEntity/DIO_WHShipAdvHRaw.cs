namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHShipAdvHRaw
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHShipAdvHRaw()
        {
            DIO_WHShipAdvDRaw = new HashSet<DIO_WHShipAdvDRaw>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column("_Stattus")]
        public byte? C_Stattus { get; set; }

        [Key]
        public int WHShipAdvHRawID { get; set; }

        [StringLength(255)]
        public string WHShipAdvNo { get; set; }

        [StringLength(255)]
        public string ShipmentID { get; set; }

        [StringLength(255)]
        public string BolNo { get; set; }

        [StringLength(255)]
        public string SONo { get; set; }

        [StringLength(255)]
        public string ShipFromName { get; set; }

        [StringLength(10)]
        public string ShipFromQualifier { get; set; }

        [StringLength(255)]
        public string ShipFromCode { get; set; }

        [StringLength(255)]
        public string ShipFromAddress { get; set; }

        [StringLength(255)]
        public string ShipFromAddress2 { get; set; }

        [StringLength(255)]
        public string ShipFromCity { get; set; }

        [StringLength(10)]
        public string ShipFromState { get; set; }

        [StringLength(10)]
        public string ShipFromZipCode { get; set; }

        [StringLength(255)]
        public string ShipFromCountry { get; set; }

        [StringLength(255)]
        public string ShipToName { get; set; }

        [StringLength(10)]
        public string ShipToQualifier { get; set; }

        [StringLength(10)]
        public string ShipToCode { get; set; }

        [StringLength(255)]
        public string ShipToAddress { get; set; }

        [StringLength(255)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToCity { get; set; }

        [StringLength(50)]
        public string ShipToState { get; set; }

        [StringLength(10)]
        public string ShipToZipCode { get; set; }

        [StringLength(255)]
        public string ShipToCountry { get; set; }

        [StringLength(10)]
        public string ShipToCountryCode { get; set; }

        [StringLength(50)]
        public string ShipToNumber { get; set; }

        [StringLength(50)]
        public string BuyerCode { get; set; }

        [StringLength(255)]
        public string ContainerNo { get; set; }

        [StringLength(255)]
        public string TrailerNo { get; set; }

        [StringLength(255)]
        public string InvoiceNo { get; set; }

        public DateTime? ShippedDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        [StringLength(50)]
        public string TransportationType { get; set; }

        [StringLength(50)]
        public string SCACCode { get; set; }

        [StringLength(255)]
        public string CarrierName { get; set; }

        [StringLength(255)]
        public string MasterBOLNo { get; set; }

        [StringLength(255)]
        public string DepositorOrderNo { get; set; }

        [StringLength(255)]
        public string ShipmentMethodOfPayment { get; set; }

        [StringLength(255)]
        public string EquipmentDescType { get; set; }

        [StringLength(255)]
        public string EquipmentInitial { get; set; }

        [StringLength(255)]
        public string EquipmentNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        [StringLength(10)]
        public string TotalWeightUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        [StringLength(10)]
        public string TotalVolumeUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLadingQty { get; set; }

        [StringLength(10)]
        public string TotalLadingQtyUOM { get; set; }

        [StringLength(10)]
        public string WeightQualifier { get; set; }

        [StringLength(10)]
        public string ReportTypeCode { get; set; }

        [StringLength(255)]
        public string AgentShipmentID { get; set; }

        [StringLength(10)]
        public string BuyerCodeQualifier { get; set; }

        [StringLength(255)]
        public string DepositorName { get; set; }

        [StringLength(50)]
        public string DepositorCode { get; set; }

        [StringLength(10)]
        public string DepositorQualifier { get; set; }

        [StringLength(255)]
        public string VesselName { get; set; }

        [StringLength(255)]
        public string ReceiverID { get; set; }

        [StringLength(255)]
        public string SequenceNo { get; set; }

        public DateTime? CreatedDate { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(10)]
        public string TotalWeightQualifier { get; set; }

        [StringLength(255)]
        public string UPCCode { get; set; }

        [StringLength(255)]
        public string BuyerName { get; set; }

        [StringLength(255)]
        public string WarehouseName { get; set; }

        [StringLength(50)]
        public string WarehouseCode { get; set; }

        [StringLength(10)]
        public string WarehouseQualifier { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        public int? WHShipOrderHeaderID { get; set; }

        public int? SOHeaderID { get; set; }

        [StringLength(255)]
        public string TrackingNumber { get; set; }

        [StringLength(255)]
        public string TrailerNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShipAdvDRaw> DIO_WHShipAdvDRaw { get; set; }
    }
}
