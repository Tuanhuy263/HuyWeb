namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ConnectingService
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(150)]
        public string Password { get; set; }

        [StringLength(250)]
        public string EndPoint { get; set; }

        [StringLength(50)]
        public string ShopName { get; set; }

        [StringLength(500)]
        public string LocalPath { get; set; }

        [StringLength(500)]
        public string MetaFile { get; set; }

        [StringLength(500)]
        public string MetaFile1 { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
