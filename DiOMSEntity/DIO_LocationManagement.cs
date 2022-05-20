namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_LocationManagement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_LocationManagement()
        {
            DIO_LocationManagement_ReceivedDate = new HashSet<DIO_LocationManagement_ReceivedDate>();
            DIO_LocationManagementDetail = new HashSet<DIO_LocationManagementDetail>();
            DIO_PackItemDetailLocation = new HashSet<DIO_PackItemDetailLocation>();
            DIO_SuggestionPrice = new HashSet<DIO_SuggestionPrice>();
            DIO_WorkOrderDetails_Location = new HashSet<DIO_WorkOrderDetails_Location>();
            DIO_ModelStock = new HashSet<DIO_ModelStock>();
        }

        [Key]
        public int LocationManagementID { get; set; }

        public int? StatusCodeID { get; set; }

        public int? MasterLocationID { get; set; }

        public int? MasterItemID { get; set; }

        public decimal? Onhand { get; set; }

        public decimal? Allocated { get; set; }

        public decimal? OnOrder { get; set; }

        public decimal? InTransit { get; set; }

        public decimal? Packed { get; set; }

        public decimal? IndividualItemQty { get; set; }

        public int? OptimisticLockField { get; set; }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        public bool? IsDefaultLocation { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedForWO { get; set; }

        [Column(TypeName = "money")]
        public decimal? InProductionQty { get; set; }

        public bool? IsCount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ForecastLeadTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? ForecastMinInventoryQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? NumberOfCartons { get; set; }

        [Column(TypeName = "money")]
        public decimal? MovingAverageGrowthRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinPOQty { get; set; }

        public int? ForecastLeadTimeShip { get; set; }

        public int? ForecastLeadTimeReceive { get; set; }

        [StringLength(100)]
        public string HighActivity { get; set; }

        public bool? IsHighVolume { get; set; }

        public byte? ItemStatus { get; set; }

        public DateTime? StartSalesDate { get; set; }

        public DateTime? EndSalesDate { get; set; }

        public bool? UseForSalesBudgetReport { get; set; }

        [Column(TypeName = "money")]
        public decimal? AllocatedForPackItem { get; set; }

        [Column(TypeName = "money")]
        public decimal? SafetyStock { get; set; }

        [Column(TypeName = "money")]
        public decimal? MovingAverageAdjustment { get; set; }

        public bool? CalcWithAverageSalesOf6WkTY { get; set; }

        [Column(TypeName = "money")]
        public decimal? OnhandSmartTurn { get; set; }

        [Column(TypeName = "money")]
        public decimal? AtpSmartTurn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationManagement_ReceivedDate> DIO_LocationManagement_ReceivedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_LocationManagementDetail> DIO_LocationManagementDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_PackItemDetailLocation> DIO_PackItemDetailLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_SuggestionPrice> DIO_SuggestionPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_WorkOrderDetails_Location> DIO_WorkOrderDetails_Location { get; set; }

        public virtual DIS_MasterItem DIS_MasterItem { get; set; }

        public virtual DIS_MasterLocation DIS_MasterLocation { get; set; }

        public virtual DIO_StatusCode DIO_StatusCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_ModelStock> DIO_ModelStock { get; set; }
    }
}
