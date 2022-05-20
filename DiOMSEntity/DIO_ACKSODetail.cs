namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ACKSODetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_ACKSODetail()
        {
            DIS_SODetail1 = new HashSet<DIS_SODetail>();
        }

        [Key]
        public int ACKSODetailID { get; set; }

        public int? LnNo { get; set; }

        public int ACKSOHeaderID { get; set; }

        public int? MasterItemID { get; set; }

        public int? ItemSubtituteID { get; set; }

        public int? UOMCodeBase { get; set; }

        public int? UOMCode { get; set; }

        public decimal? UOMRate { get; set; }

        public decimal? ConfirmQty { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Amount { get; set; }

        public int? LineItemStatusID { get; set; }

        public int? RequestReferenceNumberID { get; set; }

        [StringLength(50)]
        public string ExplainationOfChange { get; set; }

        [StringLength(50)]
        public string ExplainationOfChangeQualifier { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(48)]
        public string EDILnNo { get; set; }

        public int? SODetail { get; set; }

        [StringLength(255)]
        public string ProductCode1 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(255)]
        public string ProductCode2 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(255)]
        public string ProductCode3 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(255)]
        public string ProductCode4 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier4 { get; set; }

        [StringLength(255)]
        public string ProductCode5 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(255)]
        public string ProductCode6 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(255)]
        public string ProductCode7 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier7 { get; set; }

        [StringLength(255)]
        public string ProductCode8 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier8 { get; set; }

        [StringLength(255)]
        public string ProductCode9 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier9 { get; set; }

        [StringLength(255)]
        public string ProductCode10 { get; set; }

        [StringLength(255)]
        public string ProductCodeQualifier10 { get; set; }

        public int? ACKCompareID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShippedQty { get; set; }

        public virtual DIO_ACKCompareInfors DIO_ACKCompareInfors { get; set; }

        public virtual DIS_SODetail DIS_SODetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIS_SODetail> DIS_SODetail1 { get; set; }

        public virtual DIO_ACKSOHeader DIO_ACKSOHeader { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure { get; set; }

        public virtual DIO_LineItemStatus DIO_LineItemStatus { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIO_RequestReferenceNumber DIO_RequestReferenceNumber { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem1 { get; set; }

        public virtual DIS_UnitOfMeasure DIS_UnitOfMeasure1 { get; set; }
    }
}
