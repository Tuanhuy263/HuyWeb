namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProductActivityHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ProductActivityHeader()
        {
            DIO_ProductActivityDetail = new HashSet<DIO_ProductActivityDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(50)]
        public string TransactionControlNumber { get; set; }

        [StringLength(3)]
        public string TransactionType { get; set; }

        [StringLength(2)]
        public string TransactionHandlingType { get; set; }

        public DateTime? BeginningDateRange { get; set; }

        public DateTime? EndingDateRange { get; set; }

        public int? Status { get; set; }

        [StringLength(25)]
        public string BeginningPONumber { get; set; }

        [StringLength(25)]
        public string EndingPONumber { get; set; }

        [StringLength(30)]
        public string BatchNumber { get; set; }

        [StringLength(30)]
        public string HubID { get; set; }

        [StringLength(30)]
        public string DepartmentNo { get; set; }

        [StringLength(30)]
        public string InvoiceNo { get; set; }

        [StringLength(30)]
        public string InternalVendorNo { get; set; }

        [StringLength(60)]
        public string BuyerContactName { get; set; }

        [StringLength(80)]
        public string BuyerContactTelephone { get; set; }

        [StringLength(60)]
        public string ReportingLocationName { get; set; }

        [StringLength(80)]
        public string ReportingLocationNo { get; set; }

        [StringLength(55)]
        public string ReportingLocationAddress1 { get; set; }

        [StringLength(55)]
        public string ReportingLocationAddress2 { get; set; }

        [StringLength(30)]
        public string ReportingLocationCity { get; set; }

        [StringLength(2)]
        public string ReportingLocationState { get; set; }

        [StringLength(15)]
        public string ReportingLocationZipCode { get; set; }

        [StringLength(60)]
        public string FromName { get; set; }

        [StringLength(80)]
        public string FromLocationNo { get; set; }

        [StringLength(60)]
        public string ToName { get; set; }

        [StringLength(60)]
        public string VendorName { get; set; }

        [StringLength(80)]
        public string VendorDUNS { get; set; }

        [StringLength(55)]
        public string VendorAddress { get; set; }

        [StringLength(30)]
        public string VendorCity { get; set; }

        [StringLength(2)]
        public string VendorState { get; set; }

        [StringLength(15)]
        public string VendorZipCode { get; set; }

        [StringLength(60)]
        public string ShipToName { get; set; }

        [StringLength(80)]
        public string ShipToDUNS { get; set; }

        [StringLength(60)]
        public string ShipToAdditionalName { get; set; }

        [StringLength(55)]
        public string ShipToAddress { get; set; }

        [StringLength(30)]
        public string ShipToCity { get; set; }

        [StringLength(2)]
        public string ShipToState { get; set; }

        [StringLength(15)]
        public string ShipToZipCode { get; set; }

        [StringLength(60)]
        public string BillToName { get; set; }

        [StringLength(80)]
        public string BillToDUNS { get; set; }

        [StringLength(60)]
        public string BillToAdditionalName { get; set; }

        [StringLength(55)]
        public string BillToAddress { get; set; }

        [StringLength(30)]
        public string BillToCity { get; set; }

        [StringLength(2)]
        public string BillToState { get; set; }

        [StringLength(15)]
        public string BillToZipCode { get; set; }

        [StringLength(60)]
        public string CorporateOfficeName { get; set; }

        [StringLength(60)]
        public string StoreName { get; set; }

        [StringLength(60)]
        public string WarehouseName { get; set; }

        public int? NumberOfLineItems { get; set; }

        public int? ShipTo { get; set; }

        public int? BillTo { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(200)]
        public string HubName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductActivityDetail> DIO_ProductActivityDetail { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }
    }
}
