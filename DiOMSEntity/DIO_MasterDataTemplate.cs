namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_MasterDataTemplate
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int MasterDataTemplateID { get; set; }

        [StringLength(255)]
        public string TemplateCode { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string Path { get; set; }

        public int? TemplateType { get; set; }

        public int? Transaction { get; set; }

        public bool? ShowCaption { get; set; }

        public int? DelimiterFormat { get; set; }

        [StringLength(50)]
        public string OtherDelimiter { get; set; }

        [StringLength(100)]
        public string StoreProcedure { get; set; }

        [StringLength(100)]
        public string Extension { get; set; }

        public bool? HaveHeader { get; set; }

        public byte[] MappingContent { get; set; }

        public int? OptimisticLockField { get; set; }
    }
}
