namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_FormConfig
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(100)]
        public string FormName { get; set; }

        [StringLength(100)]
        public string ControlTag { get; set; }

        public bool? IsEnabled { get; set; }

        public bool? IsRequired { get; set; }

        [StringLength(100)]
        public string Message { get; set; }

        [StringLength(200)]
        public string ColumnHeader { get; set; }

        [StringLength(200)]
        public string DefaultValue { get; set; }

        public int? OptimisticLockField { get; set; }

        public int? TableMappedID { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int? TableID { get; set; }

        public int? HubID { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIO_FormMapping DIO_FormMapping { get; set; }

        public virtual DIO_HubFormMapping DIO_HubFormMapping { get; set; }
    }
}
