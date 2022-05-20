namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHShippingAdviceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHShippingAdviceHeader()
        {
            DIO_WHShippingAdviceDetail = new HashSet<DIO_WHShippingAdviceDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHShippingAdviceID { get; set; }

        [StringLength(255)]
        public string DocumentNo { get; set; }

        public DateTime? DocumentDate { get; set; }

        public DateTime? ShippingDate { get; set; }

        public int? Status { get; set; }

        public int? TransportMethodID { get; set; }

        public int? CarrierID { get; set; }

        public int? WHShippingOrderHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(1024)]
        public string Description { get; set; }

        public int? HubID { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        [StringLength(255)]
        public string ShippingAdviceNo { get; set; }

        [StringLength(100)]
        public string EDIShippingAdviceNo { get; set; }

        public int? ShippingInfoID { get; set; }

        public int? FOBID { get; set; }

        [StringLength(100)]
        public string ShipmentID { get; set; }

        [StringLength(100)]
        public string TransactionDate { get; set; }

        public double? LadingQuantity { get; set; }

        public double? ShipmentWeight { get; set; }

        [StringLength(100)]
        public string BillOfLadingNo { get; set; }

        public DateTime? ScheduledDeliveryDate { get; set; }

        [StringLength(100)]
        public string PurchaseOrderNo { get; set; }

        [StringLength(100)]
        public string DepartmentNumber { get; set; }

        [StringLength(100)]
        public string BuyerCode { get; set; }

        [StringLength(100)]
        public string LinkSequenceNo { get; set; }

        [StringLength(100)]
        public string POReleaseOrderNo { get; set; }

        [StringLength(100)]
        public string PCPOrderNo { get; set; }

        [StringLength(100)]
        public string MasterRefNo { get; set; }

        [StringLength(100)]
        public string BuyerName { get; set; }

        public int? ShipFromCode { get; set; }

        public int? ShipToCode { get; set; }

        [StringLength(255)]
        public string OriginalCarrierName { get; set; }

        public long? TraceStatus { get; set; }

        public DateTime? PurchaseOrderDate { get; set; }

        public int? WeightUOMID { get; set; }

        public int? WHShippingAdviceType { get; set; }

        public int? SOHeader { get; set; }

        public int? ASNNO { get; set; }

        public int? ShipToQualifier { get; set; }

        [StringLength(255)]
        public string DepositorOrderNo { get; set; }

        [StringLength(255)]
        public string ReceiverID { get; set; }

        [StringLength(255)]
        public string VesselName { get; set; }

        [StringLength(50)]
        public string DepositorCode { get; set; }

        [StringLength(10)]
        public string DepositorQualifier { get; set; }

        [StringLength(255)]
        public string DepositorName { get; set; }

        [StringLength(50)]
        public string WarehouseCode { get; set; }

        [StringLength(10)]
        public string WarehouseQualifier { get; set; }

        [StringLength(255)]
        public string WarehouseName { get; set; }

        [StringLength(10)]
        public string BuyerCodeQualifier { get; set; }

        [StringLength(10)]
        public string ShipToCountryCode { get; set; }

        [StringLength(255)]
        public string AgentShipmentID { get; set; }

        [StringLength(10)]
        public string ReportTypeCode { get; set; }

        [StringLength(10)]
        public string TotalWeightQualifier { get; set; }

        [StringLength(255)]
        public string SequenceNo { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalQty { get; set; }

        [StringLength(255)]
        public string TrackingNumber { get; set; }

        [StringLength(255)]
        public string TrailerNumber { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalVolume { get; set; }

        public int? TotalVolumeUOM { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLadingQty { get; set; }

        public int? TotalLadingQtyUOM { get; set; }

        [StringLength(255)]
        public string MasterBOLNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalWeight { get; set; }

        public int? TotalWeightUOM { get; set; }

        public virtual DIO_FOBPayment DIO_FOBPayment { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo2 { get; set; }

        public virtual DIO_ShipToQualifier DIO_ShipToQualifier { get; set; }

        public virtual DIO_TransportationMethod DIO_TransportationMethod { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHShippingAdviceDetail> DIO_WHShippingAdviceDetail { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure2 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure3 { get; set; }

        public virtual DIO_WHShippingOrderHeader DIO_WHShippingOrderHeader { get; set; }
    }
}
