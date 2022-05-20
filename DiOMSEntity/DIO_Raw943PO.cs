namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Raw943PO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Raw943PO()
        {
            DIO_Raw943Carton = new HashSet<DIO_Raw943Carton>();
            DIO_Raw943LineItem = new HashSet<DIO_Raw943LineItem>();
            DIO_Raw943Pallet = new HashSet<DIO_Raw943Pallet>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int Raw943PONo { get; set; }

        [StringLength(100)]
        public string OrderStatusCode { get; set; }

        [StringLength(100)]
        public string PurchaseOrderNo { get; set; }

        public DateTime? PurchaseOrderDate { get; set; }

        [StringLength(100)]
        public string POLadingVolume { get; set; }

        [StringLength(100)]
        public string POPackingCode { get; set; }

        [StringLength(100)]
        public string POLadingQty { get; set; }

        [StringLength(100)]
        public string POLadingWeight { get; set; }

        [StringLength(100)]
        public string InvoiceNumber { get; set; }

        [StringLength(100)]
        public string DepartmentNumber { get; set; }

        [StringLength(100)]
        public string DepartmentDescription { get; set; }

        [StringLength(100)]
        public string InternalVendorNumber { get; set; }

        [StringLength(100)]
        public string MarkForPartyStoreNumber { get; set; }

        [StringLength(100)]
        public string MarkForStoreName { get; set; }

        [StringLength(100)]
        public string MarkForStoreAddress1 { get; set; }

        [StringLength(100)]
        public string MarkForStoreAddress2 { get; set; }

        [StringLength(100)]
        public string MarkForStoreCity { get; set; }

        [StringLength(100)]
        public string MarkForStoreState { get; set; }

        [StringLength(100)]
        public string MarkForStoreZipCode { get; set; }

        [StringLength(100)]
        public string BillToNo { get; set; }

        [StringLength(100)]
        public string MerchandiseTypeCode { get; set; }

        [StringLength(100)]
        public string DescriptionCode { get; set; }

        [StringLength(100)]
        public string Special { get; set; }

        public int? OptimisticLockField { get; set; }

        public byte? Status { get; set; }

        [StringLength(100)]
        public string ErrorMessages { get; set; }

        public bool? IsValidData { get; set; }

        public bool? IsIgnored { get; set; }

        [StringLength(100)]
        public string POCombineKey { get; set; }

        [StringLength(100)]
        public string UserDefinedColumn77 { get; set; }

        [StringLength(100)]
        public string POShipmentID { get; set; }

        [StringLength(100)]
        public string UserDefinedColumn63 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943Carton> DIO_Raw943Carton { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943LineItem> DIO_Raw943LineItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Raw943Pallet> DIO_Raw943Pallet { get; set; }
    }
}
