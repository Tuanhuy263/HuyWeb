namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CleaningUpHistory")]
    public partial class CleaningUpHistory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CleaningUpHistory()
        {
            CleaningUpFilterConditions = new HashSet<CleaningUpFilterCondition>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public DateTime? ExecuteDate { get; set; }

        [StringLength(100)]
        public string BackupFilePath { get; set; }

        public bool? IsRestored { get; set; }

        [StringLength(200)]
        public string RestoredConnectionString { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CleaningUpFilterCondition> CleaningUpFilterConditions { get; set; }
    }
}
