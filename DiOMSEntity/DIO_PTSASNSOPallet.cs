namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PTSASNSOPallet
    {
        [Key]
        public int ASNSOPalletNo { get; set; }

        public int? PalletNo { get; set; }

        public int? ASNSONo { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIO_PTSASNSO DIO_PTSASNSO { get; set; }

        public virtual DIO_PTSPallet DIO_PTSPallet { get; set; }
    }
}
