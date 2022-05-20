namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CarrierInfo
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CarrierInfoID { get; set; }

        [StringLength(250)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Fax { get; set; }

        [StringLength(250)]
        public string AdditionalName { get; set; }

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
        public string Region { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string ZipCode { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [StringLength(255)]
        public string AddressQualifier { get; set; }

        [StringLength(255)]
        public string CarrierName { get; set; }

        [StringLength(255)]
        public string SCACCode { get; set; }

        [StringLength(255)]
        public string AccountNumber { get; set; }

        [StringLength(255)]
        public string ContactName { get; set; }

        [StringLength(255)]
        public string ContactPhone { get; set; }

        [StringLength(255)]
        public string ContactMail { get; set; }

        public int? BillToTransportationID { get; set; }

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ServiceType { get; set; }

        public int? Carrier { get; set; }

        public virtual DIO_BillToTransportation DIO_BillToTransportation { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }
    }
}
