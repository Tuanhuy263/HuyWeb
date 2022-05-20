namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_EPCIS_Vocabulary_Element
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_EPCIS_Vocabulary_Element()
        {
            DIO_EPCIS_Element_Attribute = new HashSet<DIO_EPCIS_Element_Attribute>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int VocabularyElementID { get; set; }

        [StringLength(100)]
        public string ID { get; set; }

        public int? Vocabulary { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_Element_Attribute> DIO_EPCIS_Element_Attribute { get; set; }

        public virtual DIO_EPCIS_Vocabulary DIO_EPCIS_Vocabulary { get; set; }
    }
}
