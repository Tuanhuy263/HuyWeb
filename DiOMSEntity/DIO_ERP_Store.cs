namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ERP_Store
    {
        [Key]
        public int ERPStoreId { get; set; }

        [StringLength(50)]
        public string ERPStoreCode { get; set; }

        public int? SystemId { get; set; }

        public int? StoreNo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_ERP_System DIO_ERP_System { get; set; }

        public virtual DIO_ShippingInfo DIO_ShippingInfo { get; set; }
    }
}
