namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawASNPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawASNPO()
        {
            DIO_RawASNPOPallet = new HashSet<DIO_RawASNPOPallet>();
            DIO_RawCarton = new HashSet<DIO_RawCarton>();
        }

        [Key]
        public int ASNPONo { get; set; }

        public int ASNNo { get; set; }

        [StringLength(50)]
        public string OrderStatusCode { get; set; }

        [StringLength(50)]
        public string PurchaseOrderNo { get; set; }

        public DateTime? PurchaseOrderDate { get; set; }

        public decimal? POLadingVolume { get; set; }

        [StringLength(50)]
        public string POPackingCode { get; set; }

        public decimal? POLadingQty { get; set; }

        public decimal? POLadingWeight { get; set; }

        [StringLength(50)]
        public string InvoiceNumber { get; set; }

        [StringLength(50)]
        public string DepartmentNumber { get; set; }

        [StringLength(255)]
        public string DepartmentDescription { get; set; }

        [StringLength(50)]
        public string InternalVendorNumber { get; set; }

        [StringLength(50)]
        public string MarkForPartyStoreNumber { get; set; }

        [StringLength(255)]
        public string MarkForStoreName { get; set; }

        [StringLength(255)]
        public string MarkForStoreAddress1 { get; set; }

        [StringLength(255)]
        public string MarkForStoreAddress2 { get; set; }

        [StringLength(50)]
        public string MarkForStoreCity { get; set; }

        [StringLength(50)]
        public string MarkForStoreState { get; set; }

        [StringLength(50)]
        public string MarkForStoreZipCode { get; set; }

        [StringLength(50)]
        public string BillToNo { get; set; }

        [StringLength(50)]
        public string MerchandiseTypeCode { get; set; }

        [StringLength(50)]
        public string DescriptionCode { get; set; }

        [StringLength(1000)]
        public string Special { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_RawASN DIO_RawASN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawASNPOPallet> DIO_RawASNPOPallet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawCarton> DIO_RawCarton { get; set; }
    }
}
