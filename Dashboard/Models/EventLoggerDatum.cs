using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventLoggerDatum
{
    public int Id { get; set; }

    public DateOnly? EventDate { get; set; }

    public string? Shift { get; set; }

    public string? Dept { get; set; }

    public string? MachineType { get; set; }

    public string? MachineNo { get; set; }

    public decimal? HourMeterReading { get; set; }

    public string? Operator { get; set; }

    public bool? Lock { get; set; }

    public string? SupervisorId { get; set; }

    public string? PartNumAtTimeOfReading { get; set; }

    public string? OpNo { get; set; }

    public string? EntryType { get; set; }

    public string? EndOfProductEnterTimeWithAmPm { get; set; }

    public decimal? Qty { get; set; }

    public decimal? FootageCounterReading { get; set; }

    public decimal? CounterTotalizerReading { get; set; }

    public string? IfDownAllDayReason { get; set; }

    public string? OtherRemark { get; set; }

    public decimal? PowerOnHours { get; set; }

    public decimal? RuntimeHrs { get; set; }

    public decimal? CuttingTimeHrs { get; set; }

    public decimal? CycletimeMin { get; set; }

    public string? Uploadby { get; set; }

    public DateTime? Uploaddate { get; set; }

    public string? JobNo { get; set; }

    public decimal? PreviousPowerOnHours { get; set; }
}
