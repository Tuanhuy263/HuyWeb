namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_PermissionAssignment
    {
        public int ID { get; set; }

        public int? RoleID { get; set; }

        public int? FunctionID { get; set; }

        public int? MenuID { get; set; }

        public int? HubID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_Function DIS_Function { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Menu DIS_Menu { get; set; }

        public virtual DIS_Role DIS_Role { get; set; }
    }
}
