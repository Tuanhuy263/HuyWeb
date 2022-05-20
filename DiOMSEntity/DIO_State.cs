namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_State()
        {
            DIO_Address = new HashSet<DIO_Address>();
            DIO_City = new HashSet<DIO_City>();
            DIO_CustomerRoutingDetail = new HashSet<DIO_CustomerRoutingDetail>();
            DIO_CustomerRoutingDetail1 = new HashSet<DIO_CustomerRoutingDetail>();
            DIO_ShippingInfo = new HashSet<DIO_ShippingInfo>();
            DIO_VendorShippingInfo = new HashSet<DIO_VendorShippingInfo>();
        }

        [Key]
        public int StateID { get; set; }

        public int CountryID { get; set; }

        [Required]
        [StringLength(250)]
        public string StateCode { get; set; }

        [StringLength(250)]
        public string StateName { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_Address> DIO_Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_City> DIO_City { get; set; }

        public virtual DIO_Country DIO_Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerRoutingDetail> DIO_CustomerRoutingDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CustomerRoutingDetail> DIO_CustomerRoutingDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ShippingInfo> DIO_ShippingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorShippingInfo> DIO_VendorShippingInfo { get; set; }
    }
}
