namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawLineItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawLineItem()
        {
            DIO_RawASNSubLineItem = new HashSet<DIO_RawASNSubLineItem>();
        }

        [Key]
        public int LineItemNo { get; set; }

        public int? CartonNo { get; set; }

        public int? POLineNo { get; set; }

        [StringLength(50)]
        public string ProductCode1 { get; set; }

        [StringLength(50)]
        public string ProductCode2 { get; set; }

        [StringLength(50)]
        public string ProductCode3 { get; set; }

        [StringLength(50)]
        public string ProductCode4 { get; set; }

        public int? LineNumber { get; set; }

        [StringLength(1000)]
        public string ProductDescription { get; set; }

        [StringLength(255)]
        public string SizeDescription_PackWeight_Height { get; set; }

        [StringLength(255)]
        public string ColorDescription_Width { get; set; }

        public decimal? TotalWeight { get; set; }

        public decimal? ShippedQty { get; set; }

        [StringLength(50)]
        public string ShippedUOM { get; set; }

        public decimal? OrderedQty { get; set; }

        [StringLength(50)]
        public string OrderUOM { get; set; }

        public decimal? QtyShippedToDate { get; set; }

        public decimal? TotalVolume { get; set; }

        [StringLength(50)]
        public string ProductCode5 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier5 { get; set; }

        [StringLength(50)]
        public string ProductCode6 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier6 { get; set; }

        [StringLength(50)]
        public string InnerPack { get; set; }

        [StringLength(50)]
        public string Pack { get; set; }

        [StringLength(50)]
        public string PackUOM { get; set; }

        [StringLength(50)]
        public string ProductCode7 { get; set; }

        [StringLength(50)]
        public string LineItemStatus { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier7 { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier1 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier2 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier3 { get; set; }

        [StringLength(50)]
        public string ProductCodeQualifier4 { get; set; }

        public byte? Status { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(255)]
        public string SubLineItemNo1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity1 { get; set; }

        [StringLength(255)]
        public string SubLineUOM1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of1 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity2 { get; set; }

        [StringLength(255)]
        public string SubLineUOM2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice2 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of2 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of2 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of2 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity3 { get; set; }

        [StringLength(255)]
        public string SubLineUOM3 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice3 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of3 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of3 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of3 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity4 { get; set; }

        [StringLength(255)]
        public string SubLineUOM4 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice4 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of4 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of4 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of4 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity5 { get; set; }

        [StringLength(255)]
        public string SubLineUOM5 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice5 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of5 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of5 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of5 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity6 { get; set; }

        [StringLength(255)]
        public string SubLineUOM6 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice6 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of6 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of6 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of6 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity7 { get; set; }

        [StringLength(255)]
        public string SubLineUOM7 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice7 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of7 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of7 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of7 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity8 { get; set; }

        [StringLength(255)]
        public string SubLineUOM8 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice8 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of8 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of8 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of8 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity9 { get; set; }

        [StringLength(255)]
        public string SubLineUOM9 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice9 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of9 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of9 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of9 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity10 { get; set; }

        [StringLength(255)]
        public string SubLineUOM10 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice10 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of10 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of10 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of10 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo11 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity11 { get; set; }

        [StringLength(255)]
        public string SubLineUOM11 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice11 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of11 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of11 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of11 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo12 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity12 { get; set; }

        [StringLength(255)]
        public string SubLineUOM12 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice12 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of12 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of12 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of12 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo13 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity13 { get; set; }

        [StringLength(255)]
        public string SubLineUOM13 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice13 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of13 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of13 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of13 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo14 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity14 { get; set; }

        [StringLength(255)]
        public string SubLineUOM14 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice14 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of14 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of14 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of14 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo15 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity15 { get; set; }

        [StringLength(255)]
        public string SubLineUOM15 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice15 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of15 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of15 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of15 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo16 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity16 { get; set; }

        [StringLength(255)]
        public string SubLineUOM16 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice16 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of16 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of16 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of16 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo17 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity17 { get; set; }

        [StringLength(255)]
        public string SubLineUOM17 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice17 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of17 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of17 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of17 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo18 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity18 { get; set; }

        [StringLength(255)]
        public string SubLineUOM18 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice18 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of18 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of18 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of18 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo19 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity19 { get; set; }

        [StringLength(255)]
        public string SubLineUOM19 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice19 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of19 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of19 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of19 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo20 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity20 { get; set; }

        [StringLength(255)]
        public string SubLineUOM20 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice20 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of20 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of20 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of20 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo21 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity21 { get; set; }

        [StringLength(255)]
        public string SubLineUOM21 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice21 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of21 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of21 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of21 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo22 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity22 { get; set; }

        [StringLength(255)]
        public string SubLineUOM22 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice22 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of22 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of22 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of22 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo23 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity23 { get; set; }

        [StringLength(255)]
        public string SubLineUOM23 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice23 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of23 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of23 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of23 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo24 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity24 { get; set; }

        [StringLength(255)]
        public string SubLineUOM24 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice24 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of24 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of24 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of24 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo25 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity25 { get; set; }

        [StringLength(255)]
        public string SubLineUOM25 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice25 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of25 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of25 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of25 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo26 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity26 { get; set; }

        [StringLength(255)]
        public string SubLineUOM26 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice26 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of26 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of26 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of26 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo27 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity27 { get; set; }

        [StringLength(255)]
        public string SubLineUOM27 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice27 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of27 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of27 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of27 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo28 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity28 { get; set; }

        [StringLength(255)]
        public string SubLineUOM28 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice28 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of28 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of28 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of28 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo29 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity29 { get; set; }

        [StringLength(255)]
        public string SubLineUOM29 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice29 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of29 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of29 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of29 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo30 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity30 { get; set; }

        [StringLength(255)]
        public string SubLineUOM30 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice30 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of30 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of30 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of30 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo31 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity31 { get; set; }

        [StringLength(255)]
        public string SubLineUOM31 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice31 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of31 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of31 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of31 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo32 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity32 { get; set; }

        [StringLength(255)]
        public string SubLineUOM32 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice32 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of32 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of32 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of32 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo33 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity33 { get; set; }

        [StringLength(255)]
        public string SubLineUOM33 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice33 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of33 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of33 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of33 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo34 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity34 { get; set; }

        [StringLength(255)]
        public string SubLineUOM34 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice34 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of34 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of34 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of34 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo35 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity35 { get; set; }

        [StringLength(255)]
        public string SubLineUOM35 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice35 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of35 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of35 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of35 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo36 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity36 { get; set; }

        [StringLength(255)]
        public string SubLineUOM36 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice36 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of36 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of36 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of36 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo37 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity37 { get; set; }

        [StringLength(255)]
        public string SubLineUOM37 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice37 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of37 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of37 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of37 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo38 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity38 { get; set; }

        [StringLength(255)]
        public string SubLineUOM38 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice38 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of38 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of38 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of38 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo39 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity39 { get; set; }

        [StringLength(255)]
        public string SubLineUOM39 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice39 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of39 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of39 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of39 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo40 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity40 { get; set; }

        [StringLength(255)]
        public string SubLineUOM40 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice40 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of40 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of40 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of40 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo41 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity41 { get; set; }

        [StringLength(255)]
        public string SubLineUOM41 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice41 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of41 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of41 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of41 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo42 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity42 { get; set; }

        [StringLength(255)]
        public string SubLineUOM42 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice42 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of42 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of42 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of42 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo43 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity43 { get; set; }

        [StringLength(255)]
        public string SubLineUOM43 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice43 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of43 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of43 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of43 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo44 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity44 { get; set; }

        [StringLength(255)]
        public string SubLineUOM44 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice44 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of44 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of44 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of44 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo45 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity45 { get; set; }

        [StringLength(255)]
        public string SubLineUOM45 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice45 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of45 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of45 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of45 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo46 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity46 { get; set; }

        [StringLength(255)]
        public string SubLineUOM46 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice46 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of46 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of46 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of46 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo47 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity47 { get; set; }

        [StringLength(255)]
        public string SubLineUOM47 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice47 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of47 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of47 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of47 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo48 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity48 { get; set; }

        [StringLength(255)]
        public string SubLineUOM48 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice48 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of48 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of48 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of48 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo49 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity49 { get; set; }

        [StringLength(255)]
        public string SubLineUOM49 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice49 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of49 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of49 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of49 { get; set; }

        [StringLength(255)]
        public string SubLineItemNo50 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineItemQuantity50 { get; set; }

        [StringLength(255)]
        public string SubLineUOM50 { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubLineUnitPrice50 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode1of50 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode2of50 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode3of50 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship1 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship2 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship3 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship4 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship5 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship6 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship7 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship8 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship9 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship10 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship11 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship12 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship13 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship14 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship15 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship16 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship17 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship18 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship19 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship20 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship21 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship22 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship23 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship24 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship25 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship26 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship27 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship28 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship29 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship30 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship31 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship32 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship33 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship34 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship35 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship36 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship37 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship38 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship39 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship40 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship41 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship42 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship43 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship44 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship45 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship46 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship47 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship48 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship49 { get; set; }

        [StringLength(255)]
        public string SubLineRelationship50 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of1 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of2 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of3 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of4 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of5 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of6 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of7 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of8 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of9 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of10 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of11 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of12 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of13 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of14 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of15 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of16 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of17 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of18 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of19 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of20 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of21 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of22 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of23 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of24 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of25 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of26 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of27 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of28 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of29 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of30 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of31 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of32 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of33 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of34 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of35 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of36 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of37 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of38 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of39 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of40 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of41 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of42 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of43 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of44 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of45 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of46 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of47 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of48 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of49 { get; set; }

        [StringLength(255)]
        public string SubLineProductCode4of50 { get; set; }

        [StringLength(100)]
        public string BatchNo { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [StringLength(100)]
        public string UPCCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawASNSubLineItem> DIO_RawASNSubLineItem { get; set; }

        public virtual DIO_RawCarton DIO_RawCarton { get; set; }
    }
}
