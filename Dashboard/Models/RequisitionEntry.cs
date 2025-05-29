using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class RequisitionEntry
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public string? RequisitionNo { get; set; }

    public string? ToolType { get; set; }

    public string? ToolName { get; set; }

    public int? Quantity { get; set; }

    public int? PreviousQuantity { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? ModifyBy { get; set; }

    public int? Rid { get; set; }

    public bool? FStatus { get; set; }

    public int? DueQuantity { get; set; }

    public string? Sconfirmation { get; set; }

    public int? IssueQut { get; set; }
}
