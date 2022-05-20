namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CompanyInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_CompanyInfo()
        {
            DIO_CompanyService = new HashSet<DIO_CompanyService>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CompanyID { get; set; }

        [StringLength(255)]
        public string CompanyName { get; set; }

        [StringLength(255)]
        public string LegalCompanyName { get; set; }

        [StringLength(100)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string CompanyWebSite { get; set; }

        [StringLength(255)]
        public string FirstMonthFiscalYear { get; set; }

        [StringLength(255)]
        public string FirstMonthIncomeTaxYear { get; set; }

        [StringLength(255)]
        public string EIN { get; set; }

        [StringLength(255)]
        public string TaxForm { get; set; }

        public int? CompanyType { get; set; }

        public int? AddressID { get; set; }

        public int? AddressBlockID { get; set; }

        public int? LegalAddressID { get; set; }

        public int? CompanyAddressForCustomerID { get; set; }

        public int? CompanyAddressBlockForCustomerID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_Address DIO_Address { get; set; }

        public virtual DIO_Address DIO_Address1 { get; set; }

        public virtual DIO_Address DIO_Address2 { get; set; }

        public virtual DIO_Address DIO_Address3 { get; set; }

        public virtual DIO_Address DIO_Address4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_CompanyService> DIO_CompanyService { get; set; }
    }
}
