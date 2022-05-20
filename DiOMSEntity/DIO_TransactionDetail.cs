namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TransactionDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int TransactionDetailID { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        public string Description { get; set; }

        public int? Index { get; set; }

        public string AssemblyName { get; set; }

        public bool? IsCheckedByDefault { get; set; }

        public bool? IsMandatory { get; set; }

        public int? TransactionID { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? IsChecked { get; set; }

        public bool? IsAllowSkipStep { get; set; }

        public bool? IsAllowIgnoreInvalidData { get; set; }

        [StringLength(100)]
        public string TransactionAssemblyType { get; set; }

        [StringLength(100)]
        public string ValidationPropertyName { get; set; }

        [StringLength(100)]
        public string ValidationDisplayPropertyName { get; set; }

        [StringLength(100)]
        public string ValidationPersistentName { get; set; }

        [StringLength(100)]
        public string OtherInfoDisplayName { get; set; }

        [StringLength(100)]
        public string OtherInfoFieldName { get; set; }

        [StringLength(100)]
        public string MinValue { get; set; }

        [StringLength(100)]
        public string MaxValue { get; set; }

        public int? ValidationType { get; set; }

        public bool? IsReadOnly { get; set; }

        public virtual DIO_Transaction DIO_Transaction { get; set; }
    }
}
