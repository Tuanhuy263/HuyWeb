namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_Enum
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int EnumID { get; set; }

        [StringLength(250)]
        public string PersistentName { get; set; }

        [StringLength(250)]
        public string FieldName { get; set; }

        public int? EnumValue { get; set; }

        [StringLength(250)]
        public string EnumName { get; set; }

        [StringLength(250)]
        public string CustomName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
