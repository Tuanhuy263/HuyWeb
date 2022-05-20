namespace DiOMSEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIO_AutomationSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIO_AutomationSchedule()
        {
            DIO_AutomationFlow = new HashSet<DIO_AutomationFlow>();
            DIO_AutoReport = new HashSet<DIO_AutoReport>();
            DIO_EmailTemplate = new HashSet<DIO_EmailTemplate>();
        }

        public bool? pl_IsLocked { get; set; }

        [StringLength(100)]
        public string pl_LockedBy { get; set; }

        public long? pl_TimeLock { get; set; }

        [StringLength(50)]
        public string UpdatedUser { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Key]
        public int ScheduleID { get; set; }

        public int? ScheduleType { get; set; }

        public DateTime? OnDateTime { get; set; }

        public int? FrequencyType { get; set; }

        public int? Frequency_Recurs_Daily_Every { get; set; }

        public int? Frequency_Recurs_Weekly_Every { get; set; }

        public bool? Frequency_Recurs_Weekly_IsMonday { get; set; }

        public bool? Frequency_Recurs_Weekly_IsTuesday { get; set; }

        public bool? Frequency_Recurs_Weekly_IsWednesday { get; set; }

        public bool? Frequency_Recurs_Weekly_IsThursday { get; set; }

        public bool? Frequency_Recurs_Weekly_IsFriday { get; set; }

        public bool? Frequency_Recurs_Weekly_IsSaturday { get; set; }

        public bool? Frequency_Recurs_Weekly_IsSunday { get; set; }

        public bool? Frequency_Monthly_IsDay { get; set; }

        public int? Frequency_Monthly_Day { get; set; }

        public int? Frequency_Monthly_Month { get; set; }

        public int? Frequency_Monthly_The_RepeatType { get; set; }

        public int? Frequency_Monthly_The_DayType { get; set; }

        public int? Frequency_Monthly_The_Month { get; set; }

        public bool? Frequency_Daily_Frequency_Occur_IsOnce { get; set; }

        public DateTime? Frequency_Daily_Frequency_Occur_Once_At { get; set; }

        public int? Frequency_Daily_Frequency_Occur_Every { get; set; }

        public int? Frequency_Daily_Frequency_Occur_Every_TimeType { get; set; }

        public DateTime? Frequency_Daily_Frequency_Occur_Every_Starting_At { get; set; }

        public DateTime? Frequency_Daily_Frequency_Occur_Every_Ending_At { get; set; }

        public DateTime? Duration_Start_Date { get; set; }

        public DateTime? Duration_End_Date { get; set; }

        public bool? Duration_Is_No_End_Date { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int? OptimisticLockField { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutomationFlow> DIO_AutomationFlow { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_AutoReport> DIO_AutoReport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIO_EmailTemplate> DIO_EmailTemplate { get; set; }
    }
}
