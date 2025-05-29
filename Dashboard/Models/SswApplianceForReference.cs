using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SswApplianceForReference
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string TypeOfAppliance { get; set; } = null!;

    public string? ApplianceType { get; set; }

    public string? ApplianceName { get; set; }

    public string? ApplianceNumber { get; set; }

    public string? Location { get; set; }

    public string? Ip { get; set; }

    public string? OtherDetail { get; set; }

    public string? MountStand { get; set; }

    public string? WindowVersion { get; set; }

    public string? PcConfiguration { get; set; }

    public string? KeyboardMouse { get; set; }

    public string? MacAddress { get; set; }

    public string? ItemImage { get; set; }

    public string? Attachment1 { get; set; }

    public string? Attachment2 { get; set; }

    public string? Attachment3 { get; set; }

    public string? Attachment4 { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? Uploaddate { get; set; }

    public DateTime? InstallmentDate { get; set; }

    public string? Purpose { get; set; }

    public DateTime? CalibrationDate { get; set; }

    public string? CalibrationReport { get; set; }

    public DateTime? NextCalibrationDate { get; set; }

    public DateTime? HandoverDate { get; set; }

    public int? HandoverTo { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Category { get; set; }

    public string? ApplianceId { get; set; }

    public string? ApplianceSourceId { get; set; }
}
