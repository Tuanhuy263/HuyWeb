namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIOW_PalletInfo
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int PalletInfoID { get; set; }

        [StringLength(250)]
        public string PalletNo { get; set; }

        [StringLength(250)]
        public string PalletCode { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public byte? Status { get; set; }

        [StringLength(250)]
        public string PONumber { get; set; }

        [StringLength(250)]
        public string LotNo { get; set; }

        public int? POHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_POHeader DIS_POHeader { get; set; }
    }
}
