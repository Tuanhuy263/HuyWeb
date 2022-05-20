namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_City
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_City()
        {
            DIO_Address = new HashSet<DIO_Address>();
            DIO_ShippingInfo = new HashSet<DIO_ShippingInfo>();
            DIO_VendorShippingInfo = new HashSet<DIO_VendorShippingInfo>();
        }

        [Key]
        public int CityID { get; set; }

        public int CountryID { get; set; }

        public int? StateID { get; set; }

        [StringLength(50)]
        public string CityCode { get; set; }

        [StringLength(250)]
        public string CityName { get; set; }

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

        public virtual DIO_Country DIO_Country { get; set; }

        public virtual DIO_State DIO_State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ShippingInfo> DIO_ShippingInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_VendorShippingInfo> DIO_VendorShippingInfo { get; set; }
    }
}
