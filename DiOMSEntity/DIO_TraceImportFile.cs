namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_TraceImportFile
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(255)]
        public string TransactionType { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }

        [StringLength(255)]
        public string FileNameSplitted { get; set; }

        [StringLength(255)]
        public string DestinationFolder { get; set; }

        public DateTime? ImportDate { get; set; }

        [StringLength(30)]
        public string ResultImportType { get; set; }

        public bool? IsFromNonEDI { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
