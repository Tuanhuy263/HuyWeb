namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CompanyService
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ServiceID { get; set; }

        [StringLength(255)]
        public string ServiceName { get; set; }

        [StringLength(250)]
        public string ServiceDomain { get; set; }

        [StringLength(250)]
        public string Status { get; set; }

        public int? CompanyInfoID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_CompanyInfo DIO_CompanyInfo { get; set; }
    }
}
