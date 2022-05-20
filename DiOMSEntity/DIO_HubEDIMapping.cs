namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_HubEDIMapping
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int HubEDIMappingID { get; set; }

        [StringLength(4000)]
        public string CustomFilename { get; set; }

        public byte[] CustomValueContent { get; set; }

        public int? MapType { get; set; }

        public int? HubID { get; set; }

        public int? EDIMappingTypeID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(4000)]
        public string StoreName { get; set; }

        public virtual DIO_EDIMappingType DIO_EDIMappingType { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }
    }
}
