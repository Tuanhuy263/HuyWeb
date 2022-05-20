namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ExternalServiceInput
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ExternalServiceParameterID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? ParameterIndex { get; set; }

        public int? DataType { get; set; }

        [StringLength(255)]
        public string DefaultValue { get; set; }

        public int? Function { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_ExternalServiceFunction DIO_ExternalServiceFunction { get; set; }
    }
}
