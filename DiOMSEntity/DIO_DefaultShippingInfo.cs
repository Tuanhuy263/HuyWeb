namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_DefaultShippingInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_DefaultShippingInfo()
        {
            DIO_CustomerRoutingDetail = new HashSet<DIO_CustomerRoutingDetail>();
            DIO_CustomerRoutingDetail1 = new HashSet<DIO_CustomerRoutingDetail>();
            DIO_HubItemStore = new HashSet<DIO_HubItemStore>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ShippingInfoID { get; set; }

        [StringLength(250)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string Address1 { get; set; }

        [StringLength(1000)]
        public string Address2 { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string ZipCode { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        public bool? DefaultShipping { get; set; }

        public bool? DefaultBillTo { get; set; }

        public bool? DefaultRemitTo { get; set; }

        public bool? DefaultShipFrom { get; set; }

        public bool? IsStore { get; set; }

        public int? HubID { get; set; }

        public int? VendorID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(250)]
        public string AdditionalName { get; set; }

        [StringLength(250)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string Region { get; set; }

        [StringLength(255)]
        public string AddressQualifier { get; set; }

        [StringLength(1000)]
        public string Address3 { get; set; }

        [StringLength(255)]
        public string WebSite { get; set; }

        [StringLength(255)]
        public string QBID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerRoutingDetail> DIO_CustomerRoutingDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerRoutingDetail> DIO_CustomerRoutingDetail1 { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_HubItemStore> DIO_HubItemStore { get; set; }
    }
}
