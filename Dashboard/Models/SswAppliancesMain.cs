using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class SswAppliancesMain
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public int Sid { get; set; }

    public string TypeOfAppliance { get; set; } = null!;

    public string? ApplianceType { get; set; }

    public string? ApplianceSubType { get; set; }

    public string? ApplianceName { get; set; }

    public string? ApplianceNumber { get; set; }

    public string? Active { get; set; }

    public string? Location { get; set; }

    public string? Ip { get; set; }

    public string? OtherDetail { get; set; }

    public string? MountStand { get; set; }

    public string? WindowVersion { get; set; }

    public string? PcConfiguration { get; set; }

    public string? KeyboardMouse { get; set; }

    public string? MacAddress { get; set; }

    public string? ItemImage { get; set; }
}
