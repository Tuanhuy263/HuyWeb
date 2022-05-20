namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_CustomerRoutingDetail
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
        public string ShipFromZipCode { get; set; }

        [StringLength(100)]
        public string ShipToZipCode { get; set; }

        public int? HandlingUnitType { get; set; }

        [Column(TypeName = "money")]
        public decimal? HandlingUnitMin { get; set; }

        [Column(TypeName = "money")]
        public decimal? HandlingUnitMax { get; set; }

        [Column(TypeName = "money")]
        public decimal? CubeMin { get; set; }

        [Column(TypeName = "money")]
        public decimal? CubeMax { get; set; }

        [StringLength(100)]
        public string Consolidator { get; set; }

        [StringLength(100)]
        public string Contact { get; set; }

        [Column(TypeName = "money")]
        public decimal? WeightMax { get; set; }

        [Column(TypeName = "money")]
        public decimal? WeightMin { get; set; }

        public int? CustomerRoutingID { get; set; }

        public int? ShipFromStateID { get; set; }

        public int? ShipToStateID { get; set; }

        public int? ShipToConsolidorAddressID { get; set; }

        public int? ShipToStoreAddressID { get; set; }

        public int? CarrierID { get; set; }

        public int? ServiceProviderMethodID { get; set; }

        public int? OptimisticLockField { get; set; }

        [StringLength(100)]
        public string ShipToState { get; set; }

        [StringLength(100)]
        public string ShipFromState { get; set; }

        public virtual DIO_CustomerRouting DIO_CustomerRouting { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIO_ServiceProviderMethod DIO_ServiceProviderMethod { get; set; }

        public virtual DIO_State DIO_State { get; set; }

        public virtual DIO_DefaultShippingInfo DIO_DefaultShippingInfo { get; set; }

        public virtual DIO_State DIO_State1 { get; set; }

        public virtual DIO_DefaultShippingInfo DIO_DefaultShippingInfo1 { get; set; }
    }
}
