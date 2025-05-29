using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProdFlexBulkShaftIssue
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string InventoryId { get; set; } = null!;

    public string? ShaftPartNumber { get; set; }

    public string? JobNumber { get; set; }

    public DateOnly? IssueDate { get; set; }

    public string? IssueTime { get; set; }

    public string? Operator { get; set; }

    public string? IssueMachineName { get; set; }

    public string? IssueMachineNo { get; set; }

    public decimal? IssueFeet { get; set; }

    public string? Shift { get; set; }

    public string? Comment { get; set; }
}
