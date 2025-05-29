using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ProdFlexPartWiseOperation
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? PartNumber { get; set; }

    public bool? AfcOp { get; set; }

    public bool? DeburringOp { get; set; }

    public bool? GaugingOp { get; set; }

    public bool? VisualInspenctionOp { get; set; }

    public bool? FlockingOp { get; set; }

    public bool? HeatingOp { get; set; }

    public bool? OverflockGaugingOp { get; set; }

    public bool? SiliconOp { get; set; }

    public bool? TappingOp { get; set; }

    public bool? AssemblyOp { get; set; }

    public bool? FinalInspectionOp { get; set; }

    public bool? RollTestOp { get; set; }

    public bool? QcInspectionOp { get; set; }

    public bool? PackingOp { get; set; }

    public DateTime? UploadDate { get; set; }

    public int? RevNo { get; set; }
}
