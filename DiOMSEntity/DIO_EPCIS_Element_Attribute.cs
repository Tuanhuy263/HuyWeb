namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_EPCIS_Element_Attribute
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int AttributeID { get; set; }

        [StringLength(100)]
        public string ID { get; set; }

        [StringLength(100)]
        public string Value { get; set; }

        public int? Element { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_EPCIS_Vocabulary_Element DIO_EPCIS_Vocabulary_Element { get; set; }
    }
}
