using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventManagementReportDetail
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string? EventId { get; set; }

    public DateTime? Eventdate { get; set; }

    public string? Shift { get; set; }

    public string? Operator { get; set; }

    public string? MachineNo { get; set; }

    public string? Shaft { get; set; }

    public decimal? Fpm { get; set; }

    public string? JobNoReelNo { get; set; }

    public decimal? Temprature { get; set; }

    public decimal? ShaftDia { get; set; }

    public decimal? InputPower { get; set; }

    public decimal? ProductionFeet { get; set; }

    public decimal? HeatCoilNumberOfTurn { get; set; }

    public decimal? HourMeterReading { get; set; }

    public decimal? StartTime { get; set; }

    public decimal? EndTime { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? EventReportType { get; set; }
}
