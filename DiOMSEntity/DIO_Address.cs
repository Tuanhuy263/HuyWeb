namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_Address()
        {
            DIO_CompanyInfo = new HashSet<DIO_CompanyInfo>();
            DIO_CompanyInfo1 = new HashSet<DIO_CompanyInfo>();
            DIO_CompanyInfo2 = new HashSet<DIO_CompanyInfo>();
            DIO_CompanyInfo3 = new HashSet<DIO_CompanyInfo>();
            DIO_CompanyInfo4 = new HashSet<DIO_CompanyInfo>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AddressID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Address1 { get; set; }

        [StringLength(250)]
        public string Address2 { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string ZipCode { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        public int? CountryInfo { get; set; }

        public int? StateID { get; set; }

        public int? CityID { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? CountryID { get; set; }

        public virtual DIO_City DIO_City { get; set; }

        public virtual DIO_Country DIO_Country { get; set; }

        public virtual DIO_Country DIO_Country1 { get; set; }

        public virtual DIO_State DIO_State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CompanyInfo> DIO_CompanyInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CompanyInfo> DIO_CompanyInfo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CompanyInfo> DIO_CompanyInfo2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CompanyInfo> DIO_CompanyInfo3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CompanyInfo> DIO_CompanyInfo4 { get; set; }
    }
}
