namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReportParameter
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(4000)]
        public string Name { get; set; }

        public string Value { get; set; }

        public bool? IsOptional { get; set; }

        public int? ParameterType { get; set; }

        public bool? IsSQLParameter { get; set; }

        public int? ReportID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_CustomReport DIO_CustomReport { get; set; }
    }
}
