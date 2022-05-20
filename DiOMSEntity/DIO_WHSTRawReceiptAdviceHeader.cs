namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WHSTRawReceiptAdviceHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WHSTRawReceiptAdviceHeader()
        {
            DIO_WHSTRawReceiptAdviceCarton = new HashSet<DIO_WHSTRawReceiptAdviceCarton>();
            DIO_WHSTRawReceiptAdviceLineItem = new HashSet<DIO_WHSTRawReceiptAdviceLineItem>();
            DIO_WHSTRawReceiptAdvicePallet = new HashSet<DIO_WHSTRawReceiptAdvicePallet>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int WHSTRawReceiptAdviceHeaderID { get; set; }

        public byte? Status { get; set; }

        [StringLength(100)]
        public string ReportingType { get; set; }

        [StringLength(100)]
        public string DepositoryOrderReceiptDate { get; set; }

        [StringLength(100)]
        public string ReceiptTimeQual { get; set; }

        [StringLength(100)]
        public string ReceiptTime { get; set; }

        [StringLength(100)]
        public string WarehouseReceiptNumber { get; set; }

        [StringLength(100)]
        public string DepositorOrderNumber { get; set; }

        [StringLength(100)]
        public string WarehouseName { get; set; }

        [StringLength(100)]
        public string WarehousecodeQualifier { get; set; }

        [StringLength(100)]
        public string WarehouseCode { get; set; }

        [StringLength(100)]
        public string WarehouseAddress1 { get; set; }

        [StringLength(100)]
        public string WarehouseAddress2 { get; set; }

        [StringLength(100)]
        public string WarehouseCity { get; set; }

        [StringLength(100)]
        public string WarehouseState { get; set; }

        [StringLength(100)]
        public string WarehouseZipcode { get; set; }

        [StringLength(100)]
        public string DepositorName { get; set; }

        [StringLength(100)]
        public string DepositorCodeQualifier { get; set; }

        [StringLength(100)]
        public string DepositorCode { get; set; }

        [StringLength(100)]
        public string DepositorContactName { get; set; }

        [StringLength(100)]
        public string DepositorContactTel_email { get; set; }

        [StringLength(100)]
        public string Messages { get; set; }

        [StringLength(100)]
        public string SpecialInstruction { get; set; }

        [StringLength(100)]
        public string ShipmentNumber { get; set; }

        [StringLength(100)]
        public string TransportMethod { get; set; }

        [StringLength(100)]
        public string SCACCode { get; set; }

        [StringLength(100)]
        public string CarrierName { get; set; }

        [StringLength(100)]
        public string Additionalinfo1 { get; set; }

        [StringLength(100)]
        public string Additionalinfo2 { get; set; }

        [StringLength(100)]
        public string Additionalinfo3 { get; set; }

        [StringLength(100)]
        public string Additionalinfo4 { get; set; }

        [StringLength(100)]
        public string Additionalinfo5 { get; set; }

        [StringLength(100)]
        public string Additionalinfo6 { get; set; }

        [StringLength(100)]
        public string Additionalinfo7 { get; set; }

        [StringLength(100)]
        public string Additionalinfo8 { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string IgnoredText { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalQuantityReceived { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCartons { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalLineNumber { get; set; }

        [StringLength(100)]
        public string SenderID { get; set; }

        [StringLength(100)]
        public string BillOfLading { get; set; }

        [StringLength(100)]
        public string ReceiptTimeType { get; set; }

        [StringLength(100)]
        public string ReceiptNumber { get; set; }

        [StringLength(255)]
        public string ContainerNo { get; set; }

        [StringLength(255)]
        public string TrailerNo { get; set; }

        [StringLength(255)]
        public string InvoiceNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHSTRawReceiptAdviceCarton> DIO_WHSTRawReceiptAdviceCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHSTRawReceiptAdviceLineItem> DIO_WHSTRawReceiptAdviceLineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WHSTRawReceiptAdvicePallet> DIO_WHSTRawReceiptAdvicePallet { get; set; }
    }
}
