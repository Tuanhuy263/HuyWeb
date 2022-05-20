namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_PassCodePermission
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? PassCodeID { get; set; }

        public int? FunctionID { get; set; }

        public int? MenuID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_PassCode DIO_PassCode { get; set; }

        public virtual DIS_Function DIS_Function { get; set; }

        public virtual DIS_Menu DIS_Menu { get; set; }
    }
}
