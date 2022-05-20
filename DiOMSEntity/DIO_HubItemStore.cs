namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_HubItemStore
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int HubItemStoreID { get; set; }

        public int? HubItem { get; set; }

        public int? DefaultShippingInfo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_DefaultShippingInfo DIO_DefaultShippingInfo { get; set; }

        public virtual DIS_HubItem DIS_HubItem { get; set; }
    }
}
