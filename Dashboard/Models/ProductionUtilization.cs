using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionUtilization
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string SetupId { get; set; } = null!;

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? MachineName { get; set; }

    public string? Shift { get; set; }

    public DateOnly? UploadDate { get; set; }

    public decimal? MachineUtilization { get; set; }

    public decimal? ProductiveTime { get; set; }

    public decimal? NonProductiveTime { get; set; }

    public decimal? MachiningQuality { get; set; }

    public string? Status { get; set; }
}
