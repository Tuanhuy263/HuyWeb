namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CleaningUpFilterCondition")]
    public partial class CleaningUpFilterCondition
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? CleaningUpHistoryID { get; set; }

        public int? TransactionType { get; set; }

        public int? DateType { get; set; }

        public int? Since { get; set; }

        public int? MonthsYears { get; set; }

        public DateTime? STTDate { get; set; }

        public DateTime? ENDDate { get; set; }

        public int? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual CleaningUpHistory CleaningUpHistory { get; set; }
    }
}
