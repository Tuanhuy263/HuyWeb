namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PrintTemplateHubVendor
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public bool? Default { get; set; }

        public int? VendorID { get; set; }

        public int? HubID { get; set; }

        public int? PrintTempID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_PrintTemplate DIO_PrintTemplate { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
