namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_OrderStatusReport870Header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_OrderStatusReport870Header()
        {
            DIO_OrderStatusReport870Detail = new HashSet<DIO_OrderStatusReport870Detail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int OrderStatusID { get; set; }

        [StringLength(250)]
        public string OrderNumber { get; set; }

        public int? OrderType { get; set; }

        [StringLength(100)]
        public string OrderReportStatus { get; set; }

        public long? OrderReportTraceStatus { get; set; }

        public DateTime? OrderReportDate { get; set; }

        [StringLength(250)]
        public string TransactionControlNo { get; set; }

        [StringLength(100)]
        public string TranType { get; set; }

        [StringLength(100)]
        public string StatusReportCode { get; set; }

        [StringLength(100)]
        public string OrderItemCode { get; set; }

        [StringLength(100)]
        public string RefQualifier { get; set; }

        [StringLength(100)]
        public string RefID { get; set; }

        [StringLength(100)]
        public string EntityIDCode1 { get; set; }

        [StringLength(100)]
        public string EntityIDName1 { get; set; }

        [StringLength(100)]
        public string EntityIDCode2 { get; set; }

        [StringLength(100)]
        public string EntityIDName2 { get; set; }

        [StringLength(100)]
        public string ContractNo { get; set; }

        public int? OrderStatusCode { get; set; }

        [StringLength(100)]
        public string DepartmentNo { get; set; }

        [StringLength(100)]
        public string VendorOrderNo { get; set; }

        public int? NumberLineItems { get; set; }

        public DateTime? OrderStatusDate { get; set; }

        public DateTime? SODate { get; set; }

        public DateTime? StatusDate { get; set; }

        public bool? IsSentEDI { get; set; }

        [StringLength(100)]
        public string ExportedTime { get; set; }

        public int? SONo { get; set; }

        public int? ShipToID { get; set; }

        public int? ShipFromID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string SpecialOrderType { get; set; }

        [StringLength(20)]
        public string TransactionPurposeCode { get; set; }

        [StringLength(250)]
        public string ShipToQualifier { get; set; }

        public int? ASNNo { get; set; }

        public long? TraceStatus { get; set; }

        [StringLength(250)]
        public string DOCIDPOStoreNumberBreakpoint { get; set; }

        [StringLength(250)]
        public string DOCIDPOStoreNumberBreakpoint1 { get; set; }

        [StringLength(250)]
        public string DOCIDPOStoreNumberconcatenated { get; set; }

        [StringLength(250)]
        public string DOCIDPOStoreNumberBreakpoint2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_OrderStatusReport870Detail> DIO_OrderStatusReport870Detail { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        public virtual DIS_SOHeader DIS_SOHeader { get; set; }
    }
}
