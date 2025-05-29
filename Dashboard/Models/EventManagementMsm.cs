using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EventManagementMsm
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string EventId { get; set; } = null!;

    public string? EventName { get; set; }

    public bool? EmployeeId { get; set; }

    public bool? Date { get; set; }

    public bool? Shift { get; set; }

    public bool? Time { get; set; }

    public bool? Msm { get; set; }

    public bool? HourMeterReading { get; set; }

    public bool? FootageCounterReading { get; set; }

    public bool? ShaftNameOrNewShaftName { get; set; }

    public bool? Fpm { get; set; }

    public bool? HeatTemp { get; set; }

    public bool? BrakeTensionTightenOrLoosen { get; set; }

    public bool? Head1Rpm { get; set; }

    public bool? Head2Rpm { get; set; }

    public bool? Head3Rpm { get; set; }

    public bool? Head4Rpm { get; set; }

    public bool? Head5Rpm { get; set; }

    public bool? CapstanRpm { get; set; }

    public bool? Reel { get; set; }

    public bool? ReelTareWeightKg { get; set; }

    public bool? ReelGrossWeightKg { get; set; }

    public bool? ApproxFeetOnReel { get; set; }

    public bool? HeadNumber { get; set; }

    public bool? NewRpm { get; set; }

    public bool? SpoolFromWindingHead { get; set; }

    public bool? Ttr { get; set; }

    public bool? DeflTol { get; set; }

    public bool? DeflLol { get; set; }

    public bool? UtsTol { get; set; }

    public bool? UtlLol { get; set; }

    public bool? PulleyTeeth { get; set; }

    public bool? OrderNo { get; set; }

    public bool? FeetPerOrder { get; set; }

    public bool? LayerFrom { get; set; }

    public bool? LayerTo { get; set; }

    public bool? ApproximateFeet { get; set; }

    public bool? RemarkReasonDetails { get; set; }

    public bool? ShaftOd { get; set; }
}
