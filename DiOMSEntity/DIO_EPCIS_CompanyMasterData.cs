namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_EPCIS_CompanyMasterData
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(100)]
        public string Identifier { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(200)]
        public string Street1 { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(10)]
        public string StateOrRegion { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(5)]
        public string Country { get; set; }

        public int? ObjectEvent { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_EPCIS_ObjectEvent DIO_EPCIS_ObjectEvent { get; set; }
    }
}
