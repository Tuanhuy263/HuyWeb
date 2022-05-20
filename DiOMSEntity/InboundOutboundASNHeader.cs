namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundOutboundASNHeader")]
    public partial class InboundOutboundASNHeader
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int InboundOutboundASNHeaderID { get; set; }

        public int? InboundASNHeaderNo { get; set; }

        public int? OutboundASNHeaderNo { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_ASN DIS_ASN { get; set; }

        public virtual DIS_ASN DIS_ASN1 { get; set; }
    }
}
