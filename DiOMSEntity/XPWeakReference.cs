namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XPWeakReference")]
    public partial class XPWeakReference
    {
        public int? GCRecord { get; set; }

        [Key]
        public Guid Oid { get; set; }

        public int? TargetType { get; set; }

        [StringLength(100)]
        public string TargetKey { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual XPObjectType XPObjectType { get; set; }
    }
}
