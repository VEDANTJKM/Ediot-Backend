using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventManagementMsmDetail
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string EventId { get; set; } = null!;

    public string? EventName { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? Date { get; set; }

    public string? Shift { get; set; }

    public TimeOnly? Time { get; set; }

    public string? Msm { get; set; }

    public decimal? HourMeterReading { get; set; }

    public decimal? FootageCounterReading { get; set; }

    public string? ShaftNameOrNewShaftName { get; set; }

    public string? Fpm { get; set; }

    public decimal? HeatTemp { get; set; }

    public string? BrakeTensionTightenOrLoosen { get; set; }

    public decimal? Head1Rpm { get; set; }

    public decimal? Head2Rpm { get; set; }

    public decimal? Head3Rpm { get; set; }

    public decimal? Head4Rpm { get; set; }

    public decimal? Head5Rpm { get; set; }

    public decimal? CapstanRpm { get; set; }

    public string? Reel { get; set; }

    public decimal? ReelTareWeightKg { get; set; }

    public decimal? ReelGrossWeightKg { get; set; }

    public decimal? ApproxFeetOnReel { get; set; }

    public string? HeadNumber { get; set; }

    public decimal? NewRpm { get; set; }

    public string? SpoolFromWindingHead { get; set; }

    public string? Ttr { get; set; }

    public decimal? DeflTol { get; set; }

    public decimal? DeflLol { get; set; }

    public decimal? UtsTol { get; set; }

    public decimal? UtlLol { get; set; }

    public string? PulleyTeeth { get; set; }

    public string? OrderNo { get; set; }

    public decimal? FeetPerOrder { get; set; }

    public string? LayerFrom { get; set; }

    public string? LayerTo { get; set; }

    public decimal? ApproximateFeet { get; set; }

    public string? RemarkReasonDetails { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? UploadBy { get; set; }

    public decimal? ShaftOd { get; set; }
}
