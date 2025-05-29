using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ShopFloorEntry
{
    public int Id { get; set; }

    public string? JobNumber { get; set; }

    public string? PartNumber { get; set; }

    public string? RequisitionNo { get; set; }

    public string? Available { get; set; }

    public string? MachineNumber { get; set; }

    public string? ToolName { get; set; }

    public int? Quantity { get; set; }

    public int? DueQuantity { get; set; }

    public bool? Active { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public int? ModifyBy { get; set; }

    public string? ToolType { get; set; }

    public int? Status { get; set; }

    public int? Rid { get; set; }

    public string? Rev { get; set; }
}
