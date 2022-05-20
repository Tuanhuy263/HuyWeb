namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_VendorMarkForStore
    {
        [Key]
        public int VendorMarkForStoreID { get; set; }

        public int VendorID { get; set; }

        public int MarkForStoreID { get; set; }

        public bool? DefaultMarkForStore { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_MarkForStore DIO_MarkForStore { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
