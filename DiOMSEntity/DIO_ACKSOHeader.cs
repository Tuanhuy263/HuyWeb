namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ACKSOHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ACKSOHeader()
        {
            DIO_ACKSODetail = new HashSet<DIO_ACKSODetail>();
            DIO_WHStockOut = new HashSet<DIO_WHStockOut>();
        }

        [Key]
        public int ACKSOHeaderID { get; set; }

        [StringLength(50)]
        public string ACKSONo { get; set; }

        public int? SONo { get; set; }

        public int? AcknowledgementTypeID { get; set; }

        public int? TransactionSetPurposeID { get; set; }

        public DateTime? ACKDate { get; set; }

        [StringLength(250)]
        public string ShipFromName { get; set; }

        [StringLength(50)]
        public string ShipFromQualifier { get; set; }

        public int? ShipFromID { get; set; }

        [StringLength(50)]
        public string ShipFromCode { get; set; }

        [StringLength(250)]
        public string ShipFromEntityIdentifier { get; set; }

        [StringLength(250)]
        public string ShipToName { get; set; }

        [StringLength(50)]
        public string ShipToQualifier { get; set; }

        public int? ShipToID { get; set; }

        [StringLength(50)]
        public string ShipToCode { get; set; }

        [StringLength(250)]
        public string ShipToEntityIdentifier { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsSentEDI { get; set; }

        public DateTime? EDIExportTime { get; set; }

        public DateTime? RevisionDate { get; set; }

        public string Note { get; set; }

        public int? HubID { get; set; }

        public DateTime? EDIExportedTime { get; set; }

        public bool? IsSendMail { get; set; }

        public long? TraceStatus { get; set; }

        public DateTime? ShipNotBefore { get; set; }

        public DateTime? ShipNotAfter { get; set; }

        public DateTime? DeliveryNotBefore { get; set; }

        public DateTime? DeliveryNotAfter { get; set; }

        public DateTime? ScheduleShipDate { get; set; }

        public bool? HasRejectItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ACKSODetail> DIO_ACKSODetail { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHStockOut> DIO_WHStockOut { get; set; }

        public virtual DIO_ACKType DIO_ACKType { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }

        public virtual DIO_TransactionSetPurpose DIO_TransactionSetPurpose { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }
    }
}
