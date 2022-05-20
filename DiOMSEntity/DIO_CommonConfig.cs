namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CommonConfig
    {
        [Key]
        public Guid RID { get; set; }

        [StringLength(100)]
        public string sectionName { get; set; }

        [StringLength(100)]
        public string entryAttributeKey { get; set; }

        [StringLength(100)]
        public string entryAttributeKeyValue { get; set; }

        [StringLength(100)]
        public string entryAttributeName { get; set; }

        [StringLength(100)]
        public string Key { get; set; }

        [StringLength(100)]
        public string attributeName { get; set; }

        [StringLength(255)]
        public string Value { get; set; }

        [StringLength(100)]
        public string Username { get; set; }
    }
}
