namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AppointmentSecurityLog
    {
        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int LogID { get; set; }

        public int? ClientID { get; set; }

        [StringLength(100)]
        public string ClientName { get; set; }

        public DateTime? TimeArrived { get; set; }

        public DateTime? TimeLeft { get; set; }

        public DateTime? ApptFromTime { get; set; }

        public DateTime? ApptToTime { get; set; }

        [StringLength(255)]
        public string LoadNo { get; set; }

        [StringLength(50)]
        public string ContainerNo { get; set; }

        [StringLength(50)]
        public string SealNo { get; set; }

        [StringLength(255)]
        public string OrderNo { get; set; }

        [StringLength(255)]
        public string ASNNo { get; set; }

        [StringLength(255)]
        public string BOLNo { get; set; }

        [StringLength(255)]
        public string EventNo { get; set; }

        [StringLength(255)]
        public string MasterEvent { get; set; }

        [StringLength(255)]
        public string DriverName { get; set; }

        [StringLength(50)]
        public string DriverID { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime? LastReminderForBeforeStart { get; set; }

        public DateTime? LastReminderForBeforeEnd { get; set; }

        public DateTime? LastReminderForMustStart { get; set; }

        public DateTime? LastReminderForLoadProcess { get; set; }

        [StringLength(50)]
        public string DoneBy { get; set; }

        public int? Status { get; set; }

        public int? PurchasingPurpose { get; set; }

        [StringLength(255)]
        public string HardCopyPath { get; set; }

        public int? Type { get; set; }

        [StringLength(255)]
        public string CarrierRefNo { get; set; }

        public string AdditionalTerms { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        public bool? IsPrinted { get; set; }

        [StringLength(100)]
        public string DocumentNo { get; set; }

        public int? DoorID { get; set; }

        public int? VendorID { get; set; }

        public int? CarrierID { get; set; }

        public int? OptimisticLockField { get; set; }

        public virtual DIO_TransportationProvider DIO_TransportationProvider { get; set; }

        public virtual DIO_Door DIO_Door { get; set; }

        public virtual DIS_Vendor DIS_Vendor { get; set; }
    }
}
