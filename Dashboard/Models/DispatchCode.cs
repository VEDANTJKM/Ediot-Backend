using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DispatchCode
{
    public int Id { get; set; }

    public string? PartNum { get; set; }

    public string? PartDesc { get; set; }

    public string? FdaProductCode { get; set; }

    public string? IndustryProductCode { get; set; }

    public decimal? Tariff { get; set; }

    public string? FdaClassification { get; set; }

    public decimal? UsHts { get; set; }

    public string? InvoiceDescription { get; set; }

    public string? Methodology { get; set; }

    public string? NotesQuestions { get; set; }
}
