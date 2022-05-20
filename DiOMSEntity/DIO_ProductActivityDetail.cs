namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ProductActivityDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ProductActivityDetail()
        {
            DIO_ProductActivityLineItem = new HashSet<DIO_ProductActivityLineItem>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public int? LineNo { get; set; }

        [StringLength(50)]
        public string ProductCode1 { get; set; }

        [StringLength(2)]
        public string ProductQualifier1 { get; set; }

        [StringLength(50)]
        public string ProductCode2 { get; set; }

        [StringLength(2)]
        public string ProductQualifier2 { get; set; }

        [StringLength(50)]
        public string ProductCode3 { get; set; }

        [StringLength(2)]
        public string ProductQualifier3 { get; set; }

        [StringLength(50)]
        public string ProductCode4 { get; set; }

        [StringLength(2)]
        public string ProductQualifier4 { get; set; }

        [StringLength(50)]
        public string ProductCode5 { get; set; }

        [StringLength(2)]
        public string ProductQualifier5 { get; set; }

        [StringLength(50)]
        public string ProductCode6 { get; set; }

        [StringLength(2)]
        public string ProductQualifier6 { get; set; }

        [StringLength(50)]
        public string ProductCode7 { get; set; }

        [StringLength(2)]
        public string ProductQualifier7 { get; set; }

        [StringLength(50)]
        public string ProductCode8 { get; set; }

        [StringLength(2)]
        public string ProductQualifier8 { get; set; }

        [StringLength(50)]
        public string ProductCode9 { get; set; }

        [StringLength(2)]
        public string ProductQualifier9 { get; set; }

        [StringLength(50)]
        public string ProductCode10 { get; set; }

        [StringLength(2)]
        public string ProductQualifier10 { get; set; }

        public int? NoOfPackPerCarton { get; set; }

        public int? NoPerPack { get; set; }

        public int? ProductAcvityHeader { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(30)]
        public string ItemManagementCode { get; set; }

        public virtual DIO_ProductActivityHeader DIO_ProductActivityHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ProductActivityLineItem> DIO_ProductActivityLineItem { get; set; }
    }
}
