namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_EPCIS_ObjectEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_EPCIS_ObjectEvent()
        {
            DIO_EPCIS_BizTransaction = new HashSet<DIO_EPCIS_BizTransaction>();
            DIO_EPCIS_CompanyMasterData = new HashSet<DIO_EPCIS_CompanyMasterData>();
            DIO_EPCIS_DestinationList = new HashSet<DIO_EPCIS_DestinationList>();
            DIO_EPCIS_Epc = new HashSet<DIO_EPCIS_Epc>();
            DIO_EPCIS_SourceList = new HashSet<DIO_EPCIS_SourceList>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int ID { get; set; }

        public DateTime? EventTime { get; set; }

        [StringLength(15)]
        public string EventTimeZoneOffset { get; set; }

        [StringLength(15)]
        public string Action { get; set; }

        [StringLength(100)]
        public string BizStep { get; set; }

        [StringLength(100)]
        public string DisPosition { get; set; }

        [StringLength(100)]
        public string ReadPoint { get; set; }

        [StringLength(100)]
        public string BizLocation { get; set; }

        [StringLength(50)]
        public string LotNumber { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int? Header { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_BizTransaction> DIO_EPCIS_BizTransaction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_CompanyMasterData> DIO_EPCIS_CompanyMasterData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_DestinationList> DIO_EPCIS_DestinationList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_Epc> DIO_EPCIS_Epc { get; set; }

        public virtual DIO_EPCIS_Header DIO_EPCIS_Header { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EPCIS_SourceList> DIO_EPCIS_SourceList { get; set; }
    }
}
