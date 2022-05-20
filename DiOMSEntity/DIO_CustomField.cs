namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomField
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? Level { get; set; }

        [StringLength(50)]
        public string FieldName { get; set; }

        public int? DataType { get; set; }

        [StringLength(50)]
        public string MappingName { get; set; }

        [StringLength(50)]
        public string Caption { get; set; }

        public bool? IsDisplayed { get; set; }

        public bool? IsModified { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
