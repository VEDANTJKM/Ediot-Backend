using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionProcessRework
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string InspectionId { get; set; } = null!;

    public string? JobNum { get; set; }

    public string? PartNum { get; set; }

    public string? InspectionType { get; set; }

    public DateTime? InspectionDate { get; set; }

    public string? DecisionType { get; set; }

    public DateTime? Endtime { get; set; }

    public decimal? Qty { get; set; }

    public decimal? RejectQty { get; set; }

    public DateTime? SentDate { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public string? DoneBy { get; set; }

    public string? DecisionOfMrb { get; set; }

    public string? MrbComment { get; set; }

    public DateTime? MrbDate { get; set; }

    public bool? CompleteRework { get; set; }

    public int? Inspectionqty { get; set; }

    public string? Qualitystage { get; set; }

    public bool? Reworkstatuschange { get; set; }
}
