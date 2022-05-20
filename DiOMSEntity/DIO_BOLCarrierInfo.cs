namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_BOLCarrierInfo
    {
        public int ID { get; set; }

        public int? BOLID { get; set; }

        [StringLength(255)]
        public string SOOriginalNumber { get; set; }

        public int? NumberOfPallets { get; set; }

        public int? NumberOfCartons { get; set; }

        public int? NumberOfPieces { get; set; }

        [StringLength(255)]
        public string SKU { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [StringLength(50)]
        public string NMFCCode { get; set; }

        [StringLength(255)]
        public string NMFCDescription { get; set; }

        public decimal? Weight { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? QtyOfHandlingUnit { get; set; }

        public int? QtyOfPackage { get; set; }

        [StringLength(100)]
        public string TypeOfHandlingUnit { get; set; }

        [StringLength(100)]
        public string TypeOfPackage { get; set; }

        public byte? IsHazardousMeterial { get; set; }

        [StringLength(100)]
        public string ASNNo { get; set; }

        public bool? IsHandlingUnit { get; set; }

        public int? ParentCarrierID { get; set; }

        public bool? IsPrintBOLMasterByComponents { get; set; }

        [StringLength(50)]
        public string CustomField_String50_1 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_2 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_3 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_4 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_5 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_6 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_7 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_8 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_9 { get; set; }

        [StringLength(50)]
        public string CustomField_String50_10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? CustomField_Decimal_10 { get; set; }

        public bool? CustomField_Bool_1 { get; set; }

        public bool? CustomField_Bool_2 { get; set; }

        public bool? CustomField_Bool_3 { get; set; }

        public bool? CustomField_Bool_4 { get; set; }

        public bool? CustomField_Bool_5 { get; set; }

        public bool? CustomField_Bool_6 { get; set; }

        public bool? CustomField_Bool_7 { get; set; }

        public bool? CustomField_Bool_8 { get; set; }

        public bool? CustomField_Bool_9 { get; set; }

        public bool? CustomField_Bool_10 { get; set; }

        public DateTime? CustomField_DateTime_1 { get; set; }

        public DateTime? CustomField_DateTime_2 { get; set; }

        public DateTime? CustomField_DateTime_3 { get; set; }

        public DateTime? CustomField_DateTime_4 { get; set; }

        public DateTime? CustomField_DateTime_5 { get; set; }

        public DateTime? CustomField_DateTime_6 { get; set; }

        public DateTime? CustomField_DateTime_7 { get; set; }

        public DateTime? CustomField_DateTime_8 { get; set; }

        public DateTime? CustomField_DateTime_9 { get; set; }

        public DateTime? CustomField_DateTime_10 { get; set; }

        public int? CustomField_Int_1 { get; set; }

        public int? CustomField_Int_2 { get; set; }

        public int? CustomField_Int_3 { get; set; }

        public int? CustomField_Int_4 { get; set; }

        public int? CustomField_Int_5 { get; set; }

        public int? CustomField_Int_6 { get; set; }

        public int? CustomField_Int_7 { get; set; }

        public int? CustomField_Int_8 { get; set; }

        public int? CustomField_Int_9 { get; set; }

        public int? CustomField_Int_10 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_1 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_2 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_3 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_4 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_5 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_6 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_7 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_8 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_9 { get; set; }

        [StringLength(4000)]
        public string CustomField_String4000_10 { get; set; }

        public long? CustomField_Long_1 { get; set; }

        public long? CustomField_Long_2 { get; set; }

        public long? CustomField_Long_3 { get; set; }

        public long? CustomField_Long_4 { get; set; }

        public long? CustomField_Long_5 { get; set; }

        public long? CustomField_Long_6 { get; set; }

        public long? CustomField_Long_7 { get; set; }

        public long? CustomField_Long_8 { get; set; }

        public long? CustomField_Long_9 { get; set; }

        public long? CustomField_Long_10 { get; set; }

        public virtual DIO_MasterBOL DIO_MasterBOL { get; set; }
    }
}
