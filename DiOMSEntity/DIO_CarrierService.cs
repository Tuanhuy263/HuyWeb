namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CarrierService
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int CarrierServiceID { get; set; }

        [StringLength(50)]
        public string CarrierServiceCode { get; set; }

        [StringLength(150)]
        public string CarrierServiceName { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(150)]
        public string Password { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        [StringLength(100)]
        public string UserDefine1 { get; set; }

        [StringLength(100)]
        public string UserDefine2 { get; set; }

        [StringLength(100)]
        public string UserDefine3 { get; set; }

        [StringLength(100)]
        public string UserDefine4 { get; set; }

        [StringLength(100)]
        public string UserDefine5 { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
