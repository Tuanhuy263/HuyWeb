namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_DownloadUploadConfig
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? Transaction { get; set; }

        public bool? Download { get; set; }

        public bool? Upload { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string HubIDs { get; set; }

        [StringLength(100)]
        public string VendorIDs { get; set; }
    }
}
