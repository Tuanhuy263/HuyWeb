namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawWHStockOutHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_RawWHStockOutHeader()
        {
            DIO_RawWHStockOutDetail = new HashSet<DIO_RawWHStockOutDetail>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public bool? Selected { get; set; }

        [StringLength(100)]
        public string CTRL_No { get; set; }

        [StringLength(100)]
        public string Order_No { get; set; }

        [StringLength(100)]
        public string Store { get; set; }

        [StringLength(100)]
        public string Customer { get; set; }

        [StringLength(100)]
        public string Cust_Name { get; set; }

        [StringLength(100)]
        public string Invoice { get; set; }

        [StringLength(100)]
        public string Disc { get; set; }

        [StringLength(100)]
        public string Credit { get; set; }

        [StringLength(100)]
        public string Appr_No { get; set; }

        [StringLength(100)]
        public string Territory { get; set; }

        [StringLength(100)]
        public string Sku { get; set; }

        [StringLength(100)]
        public string Terms_Descr { get; set; }

        [StringLength(100)]
        public string Season { get; set; }

        [StringLength(100)]
        public string Grp { get; set; }

        [StringLength(100)]
        public string Class { get; set; }

        [StringLength(100)]
        public string Style { get; set; }

        [StringLength(100)]
        public string Style_Desc { get; set; }

        [StringLength(100)]
        public string Ship_Style { get; set; }

        [StringLength(100)]
        public string Ship_Type { get; set; }

        [StringLength(100)]
        public string ShipCLR { get; set; }

        [StringLength(100)]
        public string Ship_Via { get; set; }

        [StringLength(100)]
        public string CLR { get; set; }

        [StringLength(100)]
        public string CLR_Desc { get; set; }

        [StringLength(100)]
        public string Clr_Abbr { get; set; }

        [StringLength(100)]
        public string Scale { get; set; }

        [StringLength(100)]
        public string St_Name { get; set; }

        [StringLength(100)]
        public string St_Addr_1 { get; set; }

        [StringLength(100)]
        public string St_Addr_2 { get; set; }

        [StringLength(100)]
        public string St_City { get; set; }

        [StringLength(100)]
        public string St_State { get; set; }

        [StringLength(100)]
        public string St_Postal { get; set; }

        [StringLength(100)]
        public string St_Contry { get; set; }

        [StringLength(100)]
        public string Ship_To_Rep { get; set; }

        [StringLength(100)]
        public string Corp { get; set; }

        [StringLength(100)]
        public string Div { get; set; }

        [StringLength(100)]
        public string Drop_Ship { get; set; }

        [StringLength(100)]
        public string Priority { get; set; }

        [StringLength(100)]
        public string ReOrder { get; set; }

        [StringLength(100)]
        public string Order_Hold { get; set; }

        [StringLength(100)]
        public string Ref_Art_ID { get; set; }

        [StringLength(100)]
        public string Order_Alias { get; set; }

        [StringLength(100)]
        public string Order_Mode { get; set; }

        [StringLength(100)]
        public string Order_Type { get; set; }

        [StringLength(100)]
        public string Currency { get; set; }

        [StringLength(100)]
        public string Entered_By { get; set; }

        [StringLength(100)]
        public string Modified_By { get; set; }

        [StringLength(100)]
        public string Scale_Abbr { get; set; }

        [StringLength(100)]
        public string Rep_1 { get; set; }

        [StringLength(100)]
        public string PickTKT { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public DateTime? Modify_Date { get; set; }

        public DateTime? Entry_Date { get; set; }

        public DateTime? Book_Date { get; set; }

        public DateTime? Start_Date { get; set; }

        public DateTime? Invoice_Date { get; set; }

        public DateTime? Cancel_Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? Open_Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Order_Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Ship_Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Exchange_Rate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pick_Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Extension { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Order_Value { get; set; }

        public int? Terms { get; set; }

        [Column(TypeName = "money")]
        public decimal? Disc_Rate { get; set; }

        public int? Line_No { get; set; }

        public int? Open_Sz1 { get; set; }

        public int? Open_Sz2 { get; set; }

        public int? OpenSz3 { get; set; }

        public int? Open_Sz4 { get; set; }

        public int? Open_Sz5 { get; set; }

        public int? Open_Sz6 { get; set; }

        public int? Open_Sz7 { get; set; }

        public int? Open_Sz8 { get; set; }

        public int? Open_Sz9 { get; set; }

        public int? Open_Sz10 { get; set; }

        public int? Open_Sz11 { get; set; }

        public int? OpenSz12 { get; set; }

        public int? Open_Sz13 { get; set; }

        public int? OpenSz14 { get; set; }

        public int? Open_Sz15 { get; set; }

        public int? OpenSz16 { get; set; }

        public int? Open_Sz17 { get; set; }

        public int? Open_Sz18 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Open_Extension { get; set; }

        [Column(TypeName = "money")]
        public decimal? OpenValue { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(100)]
        public string DiscCode { get; set; }

        [StringLength(100)]
        public string TermsDescription { get; set; }

        [StringLength(100)]
        public string ShipType { get; set; }

        [StringLength(100)]
        public string ShipVia { get; set; }

        [StringLength(100)]
        public string ShipToName { get; set; }

        [StringLength(100)]
        public string ShipToAddress1 { get; set; }

        [StringLength(100)]
        public string ShipToAddress2 { get; set; }

        [StringLength(100)]
        public string ShipToCity { get; set; }

        [StringLength(100)]
        public string ShipToState { get; set; }

        [StringLength(100)]
        public string ShipToPostal { get; set; }

        [StringLength(100)]
        public string ShipToContry { get; set; }

        [StringLength(100)]
        public string OrderHold { get; set; }

        [StringLength(100)]
        public string ShipToRep { get; set; }

        [StringLength(100)]
        public string DropShip { get; set; }

        [StringLength(100)]
        public string OrderAlias { get; set; }

        [StringLength(100)]
        public string OrderMode { get; set; }

        [StringLength(100)]
        public string OrderType { get; set; }

        [StringLength(100)]
        public string EnteredBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifyDate { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime? BookDate { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? CancelDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscRate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_RawWHStockOutDetail> DIO_RawWHStockOutDetail { get; set; }
    }
}
