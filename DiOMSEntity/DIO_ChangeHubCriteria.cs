namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ChangeHubCriteria
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(250)]
        public string CriteriaName { get; set; }

        [StringLength(2000)]
        public string Column { get; set; }

        public string Criteria { get; set; }

        public int? Status { get; set; }

        public bool? IsHeader { get; set; }

        public int? HubID { get; set; }

        public int? NewHubID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Hub DIS_Hub1 { get; set; }
    }
}
