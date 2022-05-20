namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_ExternalInventory
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(200)]
        public string Style_Description { get; set; }

        [StringLength(50)]
        public string Style { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string Color_Description { get; set; }

        [StringLength(50)]
        public string Div { get; set; }

        [StringLength(50)]
        public string Season { get; set; }

        [StringLength(50)]
        public string GRP { get; set; }

        [StringLength(50)]
        public string WarehouseCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? Quantity { get; set; }

        public int? SizeIndex { get; set; }

        public int? OptimisticLockField { get; set; }

        public int ID { get; set; }

        public int? SizeNum { get; set; }

        [StringLength(50)]
        public string SizeName { get; set; }

        [StringLength(50)]
        public string Color_Abbreviation { get; set; }

        [Column(TypeName = "money")]
        public decimal? OnHand { get; set; }

        [Column(TypeName = "money")]
        public decimal? Open_Orders { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bom_Configuration { get; set; }

        [Column(TypeName = "money")]
        public decimal? ATS_Stock { get; set; }

        [Column(TypeName = "money")]
        public decimal? WIP { get; set; }

        [Column(TypeName = "money")]
        public decimal? ATS { get; set; }

        [Column(TypeName = "money")]
        public decimal? Planned_WIP { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bom_Plan { get; set; }

        [Column(TypeName = "money")]
        public decimal? ATS_Plan { get; set; }

        [Column(TypeName = "money")]
        public decimal? In_Pick { get; set; }

        [Column(TypeName = "money")]
        public decimal? Booked { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cancelled { get; set; }

        [Column(TypeName = "money")]
        public decimal? Shipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? Returned { get; set; }

        [Column(TypeName = "money")]
        public decimal? Received { get; set; }

        [Column(TypeName = "money")]
        public decimal? Purchases { get; set; }

        [Column(TypeName = "money")]
        public decimal? Adjusted { get; set; }

        [Column(TypeName = "money")]
        public decimal? Bom_Used { get; set; }

        [Column(TypeName = "money")]
        public decimal? On_Shipment { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sub_Order { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sub_Pick { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sub_Shipped { get; set; }

        [Column(TypeName = "money")]
        public decimal? ATS_UnAssigned { get; set; }

        [Column(TypeName = "money")]
        public decimal? Safety_Stock { get; set; }

        [Column(TypeName = "money")]
        public decimal? Min_Available_Qty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Reorder_Qty { get; set; }

        [StringLength(50)]
        public string Stype_Type { get; set; }

        [StringLength(50)]
        public string Corp { get; set; }

        [StringLength(50)]
        public string Class { get; set; }

        [StringLength(50)]
        public string Master_Style { get; set; }

        [StringLength(50)]
        public string Style_Alias { get; set; }

        [StringLength(50)]
        public string Style_Vendor { get; set; }

        [StringLength(50)]
        public string Style_Customer { get; set; }

        [StringLength(50)]
        public string Manf_Ref { get; set; }

        [StringLength(50)]
        public string Design_Ref { get; set; }

        [StringLength(50)]
        public string Body_Ref { get; set; }

        [StringLength(50)]
        public string Cloth_Ref { get; set; }

        [StringLength(50)]
        public string Style_Ref1 { get; set; }

        [StringLength(50)]
        public string Style_Ref2 { get; set; }

        [StringLength(50)]
        public string Style_Ref3 { get; set; }

        [StringLength(50)]
        public string Style_Ref4 { get; set; }

        [StringLength(50)]
        public string Style_Ref5 { get; set; }

        [StringLength(50)]
        public string Royalty_Code { get; set; }

        [StringLength(50)]
        public string Art_Id { get; set; }

        [StringLength(50)]
        public string Style_Controller { get; set; }

        public int? Style_Entry_Date { get; set; }

        [StringLength(50)]
        public string Style_Entered_By { get; set; }

        [StringLength(50)]
        public string Sku { get; set; }

        [StringLength(100)]
        public string Sku_Description { get; set; }

        [StringLength(50)]
        public string Scale { get; set; }

        [StringLength(100)]
        public string Scale_Abbriviation { get; set; }

        [Column(TypeName = "money")]
        public decimal? Pack_Qty { get; set; }

        [StringLength(50)]
        public string Sku_Ref1 { get; set; }

        [StringLength(50)]
        public string Sku_Ref2 { get; set; }

        [StringLength(50)]
        public string Sku_Season { get; set; }

        [Column(TypeName = "money")]
        public decimal? Line_Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Retail_Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Std_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Avg_Cost { get; set; }

        [Column(TypeName = "money")]
        public decimal? Last_Cost { get; set; }

        public DateTime? Last_Rec_Date { get; set; }

        [StringLength(100)]
        public string Last_Rec_PO { get; set; }

        [Column(TypeName = "money")]
        public decimal? Last_Rec_Qty { get; set; }

        public DateTime? Next_Eta_Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? Next_Eta_PO { get; set; }

        [Column(TypeName = "money")]
        public decimal? Next_Eta_Qty { get; set; }

        public DateTime? Last_Book_Date { get; set; }

        [StringLength(100)]
        public string Last_Ctrl_No { get; set; }

        [Column(TypeName = "money")]
        public decimal? Last_Book_Qty { get; set; }

        public DateTime? Last_Invoice_Date { get; set; }

        [StringLength(100)]
        public string Last_Invoice_No { get; set; }

        [Column(TypeName = "money")]
        public decimal? Last_Invoice_Qty { get; set; }

        [StringLength(50)]
        public string Period_Sales { get; set; }

        [Column(TypeName = "money")]
        public decimal? Average_Sales { get; set; }

        [StringLength(50)]
        public string Sales_Supply { get; set; }

        [StringLength(50)]
        public string Sales_YTD { get; set; }

        [StringLength(50)]
        public string Sales_LY { get; set; }

        [StringLength(50)]
        public string Sales_STAT_1 { get; set; }

        [StringLength(50)]
        public string Sales_STAT_2 { get; set; }

        [StringLength(50)]
        public string UPC_No { get; set; }

        [StringLength(50)]
        public string NRF_Color { get; set; }

        [StringLength(50)]
        public string NRF_Size { get; set; }

        [StringLength(50)]
        public string Safety_Stock_Alert { get; set; }

        [StringLength(50)]
        public string Min_Reorder_Alert { get; set; }

        [StringLength(50)]
        public string Oversold_Alert { get; set; }

        [StringLength(50)]
        public string User_Column1 { get; set; }

        [StringLength(50)]
        public string User_Column2 { get; set; }

        [StringLength(50)]
        public string User_Column3 { get; set; }

        [StringLength(50)]
        public string User_Column4 { get; set; }

        [StringLength(50)]
        public string User_Column5 { get; set; }

        [StringLength(50)]
        public string G1_Value { get; set; }

        [StringLength(50)]
        public string G1_Description { get; set; }

        public int? G1_Rank { get; set; }

        [StringLength(50)]
        public string G1_Rank_Value { get; set; }

        [StringLength(50)]
        public string G2_Value { get; set; }

        [StringLength(50)]
        public string G2_Description { get; set; }

        public int? G2_Rank { get; set; }

        [StringLength(50)]
        public string G2_Rank_Value { get; set; }

        [StringLength(50)]
        public string G3_Value { get; set; }

        [StringLength(50)]
        public string G3_Description { get; set; }

        public int? G3_Rank { get; set; }

        [StringLength(50)]
        public string G3_Rank_Value { get; set; }

        [StringLength(50)]
        public string G4_Value { get; set; }

        [StringLength(50)]
        public string G4_Description { get; set; }

        public int? G4_Rank { get; set; }

        [StringLength(50)]
        public string G4_Rank_Value { get; set; }

        [StringLength(50)]
        public string Rpt_Tf_Period { get; set; }

        [StringLength(50)]
        public string Rpt_Tf_Period_End { get; set; }

        [StringLength(50)]
        public string Rpt_Age_Days { get; set; }

        [StringLength(50)]
        public string Rpt_Age_Period { get; set; }

        [StringLength(50)]
        public string Entered_By { get; set; }

        public DateTime? ImportDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? NAvailableQty { get; set; }
    }
}
