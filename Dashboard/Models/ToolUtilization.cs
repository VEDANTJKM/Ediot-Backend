using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ToolUtilization
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? ToolCategory { get; set; }

    public string? ToolName { get; set; }

    public int? OrderQty { get; set; }

    public int? ReceivedQty { get; set; }

    public string? Status { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? Uploadedby { get; set; }

    public int? ShopFloorOnhandQty { get; set; }

    public string? MachineType { get; set; }

    public string? ReqStatus { get; set; }

    public int? StoreOnHandQty { get; set; }

    public string? Jobno { get; set; }

    public string? MachineName { get; set; }

    public string? PartNo { get; set; }

    public string? Rev { get; set; }

    public int? IssueQty { get; set; }

    public int? TransactionQty { get; set; }

    public DateTime? TransactionDate { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateTime? TransactionTransactionDate { get; set; }
}
