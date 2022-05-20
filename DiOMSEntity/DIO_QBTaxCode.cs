namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_QBTaxCode
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TaxCodeID { get; set; }

        [StringLength(20)]
        public string TaxCode { get; set; }

        [StringLength(250)]
        public string Desciption { get; set; }

        public bool? IsTaxable { get; set; }

        [StringLength(250)]
        public string QBID { get; set; }

        public DateTime? QBModified { get; set; }

        public DateTime? LastSyncDate { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
