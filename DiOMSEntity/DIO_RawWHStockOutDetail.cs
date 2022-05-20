namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_RawWHStockOutDetail
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        [StringLength(100)]
        public string CTRL_No { get; set; }

        [StringLength(100)]
        public string Order_No { get; set; }

        [StringLength(100)]
        public string Store { get; set; }

        [StringLength(100)]
        public string Customer { get; set; }

        [StringLength(100)]
        public string CustomerName { get; set; }

        [StringLength(100)]
        public string InvoiceNo { get; set; }

        [StringLength(100)]
        public string PO { get; set; }

        [StringLength(100)]
        public string DiscCode { get; set; }

        [StringLength(100)]
        public string Credit { get; set; }

        [StringLength(100)]
        public string ApprNo { get; set; }

        [StringLength(100)]
        public string Territory { get; set; }

        [StringLength(100)]
        public string Sku { get; set; }

        [StringLength(100)]
        public string TermsDescription { get; set; }

        [StringLength(100)]
        public string Season { get; set; }

        [StringLength(100)]
        public string Grp { get; set; }

        [StringLength(100)]
        public string Class { get; set; }

        [StringLength(100)]
        public string Style { get; set; }

        [StringLength(100)]
        public string StyleDescription { get; set; }

        [StringLength(100)]
        public string ShipStyle { get; set; }

        [StringLength(100)]
        public string ShipType { get; set; }

        [StringLength(100)]
        public string ShipCLR { get; set; }

        [StringLength(100)]
        public string ShipVia { get; set; }

        [StringLength(100)]
        public string CLR { get; set; }

        [StringLength(100)]
        public string ClrDescription { get; set; }

        [StringLength(100)]
        public string ClrAbbr { get; set; }

        [StringLength(100)]
        public string Scale { get; set; }

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
        public string ShipToRep { get; set; }

        [StringLength(100)]
        public string Corp { get; set; }

        [StringLength(100)]
        public string Div { get; set; }

        [StringLength(100)]
        public string DropShip { get; set; }

        [StringLength(100)]
        public string Priority { get; set; }

        [StringLength(100)]
        public string ReOrder { get; set; }

        [StringLength(100)]
        public string OrderHold { get; set; }

        [StringLength(100)]
        public string LotRef { get; set; }

        [StringLength(100)]
        public string SubStyle { get; set; }

        [StringLength(100)]
        public string SubClr { get; set; }

        [StringLength(100)]
        public string SubLotRef { get; set; }

        [StringLength(100)]
        public string ShipLotRef { get; set; }

        [StringLength(100)]
        public string DcNo { get; set; }

        [StringLength(100)]
        public string CustDept { get; set; }

        [StringLength(100)]
        public string Region { get; set; }

        [StringLength(100)]
        public string FobPoint { get; set; }

        [StringLength(100)]
        public string Factor { get; set; }

        [StringLength(100)]
        public string OrderTrack { get; set; }

        [StringLength(100)]
        public string PtTrack { get; set; }

        [StringLength(100)]
        public string FillRule { get; set; }

        [StringLength(100)]
        public string FirstCostRule { get; set; }

        [StringLength(100)]
        public string OrderController { get; set; }

        [StringLength(100)]
        public string OrderApprStatus { get; set; }

        [StringLength(100)]
        public string CancelCode { get; set; }

        [StringLength(100)]
        public string PromoCode { get; set; }

        [StringLength(100)]
        public string OrderRef1 { get; set; }

        [StringLength(100)]
        public string OrderRef2 { get; set; }

        [StringLength(100)]
        public string OrderRef3 { get; set; }

        [StringLength(100)]
        public string OrderRef4 { get; set; }

        [StringLength(100)]
        public string OrderRef5 { get; set; }

        [StringLength(100)]
        public string RefArtID { get; set; }

        [StringLength(100)]
        public string OrderAlias { get; set; }

        [StringLength(100)]
        public string OrderMode { get; set; }

        [StringLength(100)]
        public string OrderType { get; set; }

        [StringLength(100)]
        public string Currency { get; set; }

        [StringLength(100)]
        public string EnteredBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        [StringLength(100)]
        public string ScaleAbbr { get; set; }

        [StringLength(100)]
        public string Rep1 { get; set; }

        [StringLength(100)]
        public string PickTKT { get; set; }

        [StringLength(100)]
        public string Status { get; set; }

        public DateTime? ModifyDate { get; set; }

        public DateTime? EntryDate { get; set; }

        public DateTime? BookDate { get; set; }

        public DateTime? OrderTrackDate { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public DateTime? CancelDate { get; set; }

        public DateTime? CanceledOnDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? OpenQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? CancelQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? ShipQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? ExchangeRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? PickQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? Extension { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? OrderValue { get; set; }

        public int? Terms { get; set; }

        public int? PoLineNo { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscRate { get; set; }

        public int? Line_No { get; set; }

        [Column(TypeName = "money")]
        public decimal? Ratio { get; set; }

        public int? OpenSize1 { get; set; }

        public int? OpenSize2 { get; set; }

        public int? OpenSize3 { get; set; }

        public int? OpenSize4 { get; set; }

        public int? OpenSize5 { get; set; }

        public int? OpenSize6 { get; set; }

        public int? OpenSize7 { get; set; }

        public int? OpenSize8 { get; set; }

        public int? OpenSize9 { get; set; }

        public int? OpenSize10 { get; set; }

        public int? OpenSize11 { get; set; }

        public int? OpenSize12 { get; set; }

        public int? OpenSize13 { get; set; }

        public int? OpenSize14 { get; set; }

        public int? OpenSize15 { get; set; }

        public int? OpenSize16 { get; set; }

        public int? OpenSize17 { get; set; }

        public int? OpenSize18 { get; set; }

        [Column(TypeName = "money")]
        public decimal? OpenExtension { get; set; }

        [Column(TypeName = "money")]
        public decimal? OpenValue { get; set; }

        public int? ProjectId { get; set; }

        public int? PriceListId { get; set; }

        [StringLength(100)]
        public string BookSeason { get; set; }

        public DateTime? EventDate { get; set; }

        [StringLength(100)]
        public string WH { get; set; }

        [StringLength(100)]
        public string Rep2 { get; set; }

        [StringLength(100)]
        public string Rep3 { get; set; }

        public int? RawWHStockOutHeaderID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_RawWHStockOutHeader DIO_RawWHStockOutHeader { get; set; }
    }
}
