namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ASNBOL
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public bool? IsUsed { get; set; }

        public int? MasterBOL { get; set; }

        public int? ASN { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIO_MasterBOL DIO_MasterBOL { get; set; }
    }
}
