namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_FTPAccountNonEDI
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int FTPAccountNonEDIID { get; set; }

        public int? TransactionCode { get; set; }

        [StringLength(100)]
        public string UploadPathNonEDI { get; set; }

        [StringLength(100)]
        public string DownloadPathNonEDI { get; set; }

        [StringLength(100)]
        public string LocalDownloadFolderNonEDI { get; set; }

        [StringLength(100)]
        public string LocalUploadFolderNonEDI { get; set; }

        public int? FTPAccountID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_FTPAccount DIO_FTPAccount { get; set; }
    }
}
