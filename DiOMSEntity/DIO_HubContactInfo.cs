namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_HubContactInfo
    {
        [Key]
        public int HubContactInfoID { get; set; }

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

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(250)]
        public string FirstName { get; set; }

        [StringLength(250)]
        public string MiddleName { get; set; }

        [StringLength(250)]
        public string LastName { get; set; }

        [StringLength(255)]
        public string AltPhone { get; set; }

        public bool? DefaultContact { get; set; }

        [StringLength(250)]
        public string Address1 { get; set; }

        [StringLength(250)]
        public string Address2 { get; set; }

        [StringLength(250)]
        public string Address3 { get; set; }

        [StringLength(250)]
        public string City { get; set; }

        [StringLength(250)]
        public string State { get; set; }

        [StringLength(250)]
        public string ZipCode { get; set; }

        [StringLength(250)]
        public string Country { get; set; }

        [StringLength(250)]
        public string AttentionTo { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }
    }
}
