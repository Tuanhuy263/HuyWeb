namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_VendorShippingInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_VendorShippingInfo()
        {
            DIO_PurchaseTransitTime = new HashSet<DIO_PurchaseTransitTime>();
        }

        [Key]
        public int VendorShippingInfoID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Address1 { get; set; }

        [StringLength(250)]
        public string Address2 { get; set; }

        public int? CityID { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        public int? StateID { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string ZipCode { get; set; }

        public int? CountryID { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        public int? VendorID { get; set; }

        public bool? DefaultShipping { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(30)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public virtual DIO_City DIO_City { get; set; }

        public virtual DIO_Country DIO_Country { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PurchaseTransitTime> DIO_PurchaseTransitTime { get; set; }

        public virtual DIO_State DIO_State { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
