namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ASNLabelTemplate
    {
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string TemplateName { get; set; }

        [Required]
        [StringLength(4000)]
        public string FileName { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte[] ContentTemplate { get; set; }

        public int? HubID { get; set; }

        public int? VendorID { get; set; }

        public virtual DIS_Hub DIS_Hub { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
