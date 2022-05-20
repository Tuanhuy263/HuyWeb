namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_VendorContactInfo
    {
        [Key]
        public int VendorContactInfoID { get; set; }

        [Required]
        [StringLength(250)]
        public string PersonName { get; set; }

        [StringLength(250)]
        public string TitleName { get; set; }

        [StringLength(255)]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        public string FaxNumber { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        public int? VendorID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(20)]
        public string Prefix { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string MiddleName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(1000)]
        public string Address1 { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(1000)]
        public string AddressCity { get; set; }

        [StringLength(255)]
        public string ZipCode { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
