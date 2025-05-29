using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ToolingUtilizationAllDetail
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int? TransactionId { get; set; }

    public string? ToolType { get; set; }

    public string? ToolName { get; set; }

    public int? OrderQty { get; set; }

    public int? ShopFloorQty { get; set; }

    public int? TransactionQty { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? JobNo { get; set; }

    public string? PartNo { get; set; }

    public string? Rev { get; set; }

    public string? TransactionBy { get; set; }

    public string? Status { get; set; }

    public string? MachineType { get; set; }

    public int? ReturnToStockQtyShopFloor { get; set; }

    public int? ReturnToScrapQtyShopFloor { get; set; }

    public int? Pid { get; set; }

    public string? OparatorReceiveQty { get; set; }

    public int? OperatorReceiveQty { get; set; }

    public DateTime? OperatorReceiveDate { get; set; }

    public int? PendingQty { get; set; }

    public string? MachineName { get; set; }

    public int? ReturnToStockQtyStore { get; set; }

    public int? ReturnToScrapQtyStore { get; set; }

    public string? RemarkShopfloor { get; set; }

    public string? RemarkStore { get; set; }
}
