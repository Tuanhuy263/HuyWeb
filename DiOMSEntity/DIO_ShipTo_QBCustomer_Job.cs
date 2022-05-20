namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ShipTo_QBCustomer_Job
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string ShipToCode { get; set; }

        [StringLength(255)]
        public string ShipToName { get; set; }

        [StringLength(255)]
        public string ShipToAddress1 { get; set; }

        [StringLength(255)]
        public string ShipToAddress2 { get; set; }

        [StringLength(255)]
        public string ShipToCity { get; set; }

        [StringLength(255)]
        public string ShipToState { get; set; }

        [StringLength(255)]
        public string ShipToCountry { get; set; }

        [StringLength(255)]
        public string ShipToZipCode { get; set; }

        [StringLength(255)]
        public string QBCustomerID { get; set; }

        [StringLength(255)]
        public string QBCustomerName { get; set; }

        public int? Hub { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }
    }
}
