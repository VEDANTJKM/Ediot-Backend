using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ToolInventorySystem
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public int ToolId { get; set; }

    public string? PartName { get; set; }

    public string? PartDscription { get; set; }

    public string? ToolType { get; set; }

    public string? ProductClass { get; set; }

    public string? ProductGroup { get; set; }

    public string? Uom { get; set; }

    public int? QtyAsPerPhysicalStock { get; set; }

    public int? MinQty { get; set; }

    public int? ItemQtyInBox { get; set; }

    public string? Active { get; set; }

    public string? Remark { get; set; }
}
