namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutoFillShippingInfoMapping
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AutoFillShippingInfoMapping { get; set; }

        public int? ServiceID { get; set; }

        public int? GetInfoByCityFunctionID { get; set; }

        public int? GetInfoByStateFunctionID { get; set; }

        public int? GetInfoByZipCodeFunctionID { get; set; }

        public int? GetGeographyFunctionID { get; set; }

        [StringLength(32)]
        public string AddressTag { get; set; }

        [StringLength(32)]
        public string CountryTag { get; set; }

        [StringLength(32)]
        public string StateTag { get; set; }

        [StringLength(32)]
        public string CityTag { get; set; }

        [StringLength(32)]
        public string ZipCodeTag { get; set; }

        [StringLength(32)]
        public string GrouppingTag { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
