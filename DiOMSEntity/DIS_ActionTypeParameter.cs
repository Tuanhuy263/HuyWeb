namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIS_ActionTypeParameter
    {
        [Key]
        public int ActionTypeParameterID { get; set; }

        public int ActionTypeID { get; set; }

        public int ParameterID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual DIS_ActionType DIS_ActionType { get; set; }

        public virtual DIS_TemplateParameter DIS_TemplateParameter { get; set; }
    }
}
