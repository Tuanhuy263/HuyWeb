namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ReminderReportQuery
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
        public string QueryName { get; set; }

        public string QueryContent { get; set; }

        [StringLength(255)]
        public string Caption { get; set; }

        public string SaveFilter { get; set; }

        [StringLength(255)]
        public string FullFormName { get; set; }

        [StringLength(255)]
        public string FullAssemblyName { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsCheckFileExisted { get; set; }

        public bool? IsFileServer { get; set; }

        public bool? NeedParameter { get; set; }

        [StringLength(2000)]
        public string FolderPath { get; set; }

        public int? TransactionNumber { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(255)]
        public string GroupName { get; set; }

        public int? GroupOrder { get; set; }

        public int? QueryOrder { get; set; }

        public string CriteriaString { get; set; }

        [StringLength(255)]
        public string Username { get; set; }

        public bool? IsEDITransaction { get; set; }

        [StringLength(255)]
        public string ModuleName { get; set; }

        public int? FTPAccountID { get; set; }

        public int? Menu { get; set; }

        public bool? IsToday { get; set; }

        public int? NumberOfDate { get; set; }
    }
}
