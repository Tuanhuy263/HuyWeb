namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ERP_TransportationProvider
    {
        public int ID { get; set; }

        public int TransportationProviderID { get; set; }

        [StringLength(255)]
        public string QBShipMethodID { get; set; }

        [StringLength(255)]
        public string QBShipMethodName { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }
    }
}
