using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProductionToolDetail
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string ToolId { get; set; } = null!;

    public string? ProductionId { get; set; }

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? RevNo { get; set; }

    public int? OpNo { get; set; }

    public string? Shift { get; set; }

    public string? Operator { get; set; }

    public string? Toolname { get; set; }

    public string? InsertOrCorner { get; set; }

    public string? NewOrUsed { get; set; }

    public string? RuffOrFinish { get; set; }

    public int? PieceMade { get; set; }

    public string? Remark { get; set; }
}
