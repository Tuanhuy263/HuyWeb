namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_WSTReceiptAdvicePalletPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_WSTReceiptAdvicePalletPO()
        {
            DIO_WSTReceiptAdviceCarton = new HashSet<DIO_WSTReceiptAdviceCarton>();
            DIO_WSTReceiptAdviceLineItem = new HashSet<DIO_WSTReceiptAdviceLineItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ReceiptAdvicePalletPOId { get; set; }

        [StringLength(50)]
        public string TransactionPurposeCode { get; set; }

        [StringLength(50)]
        public string InvoiceNumber { get; set; }

        [StringLength(50)]
        public string DepartmentNumber { get; set; }

        [StringLength(50)]
        public string DepartmentDescription { get; set; }

        [StringLength(50)]
        public string InternalVendorNumber { get; set; }

        [StringLength(50)]
        public string MerchandiseTypeCode { get; set; }

        [StringLength(50)]
        public string UserDefinied77 { get; set; }

        [StringLength(50)]
        public string DummyPONo { get; set; }

        [StringLength(50)]
        public string PONumber { get; set; }

        [StringLength(50)]
        public string ASNNumber { get; set; }

        public int? ReceiptAdvicePalletId { get; set; }

        public int? PONo { get; set; }

        public int? ASNNo { get; set; }

        public int? MarkForStoreId { get; set; }

        public int? BillToId { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceCarton> DIO_WSTReceiptAdviceCarton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WSTReceiptAdviceLineItem> DIO_WSTReceiptAdviceLineItem { get; set; }

        public virtual DIO_WSTReceiptAdvicePallet DIO_WSTReceiptAdvicePallet { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }
    }
}
