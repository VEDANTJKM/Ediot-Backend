using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionDocumentDatum
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public string DocumentName { get; set; } = null!;

    public string? VerifiactionInstruction { get; set; }

    public string? Comments { get; set; }

    public string? Passfail { get; set; }

    public string? AfterCorrectionpassfail { get; set; }

    public DateTime? CurrentDate { get; set; }

    public bool? Active { get; set; }

    public bool? Delete { get; set; }

    public string? Email { get; set; }
}
