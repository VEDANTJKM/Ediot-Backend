using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProgramOperationWiseToolLibrary
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? PartName { get; set; }

    public string? OpNo { get; set; }

    public string? TypeOfOperation { get; set; }

    public string? ToolType { get; set; }

    public string? ToolName { get; set; }

    public string? MachineName { get; set; }

    public int? ProgramId { get; set; }

    public string? MachineNo { get; set; }

    public string? JobNo { get; set; }

    public string? RevNo { get; set; }

    public bool? Active { get; set; }
}
