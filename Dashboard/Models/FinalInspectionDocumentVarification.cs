using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FinalInspectionDocumentVarification
{
    public int Id { get; set; }

    public int Iid { get; set; }

    public int DocumentId { get; set; }

    public string? Comments { get; set; }

    public string? Passfail { get; set; }

    public string? AfterCorrectionpassfail { get; set; }

    public DateTime? CurrentDate { get; set; }

    public bool? Active { get; set; }

    public bool? Delete { get; set; }
}
