using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FpaFormHistory
{
    public int Id { get; set; }

    public int? FpaFormId { get; set; }

    public string? Dimension1 { get; set; }

    public string? Dimension2 { get; set; }

    public string? Dimension3 { get; set; }

    public string? Dimension4 { get; set; }

    public string? ResultsByProgrammer { get; set; }

    public string? ResultsByInspector { get; set; }

    public string? InstrumentId { get; set; }

    public string? Remark { get; set; }

    public string? DimensionTotal { get; set; }

    public DateTime? Datetime { get; set; }

    public string? Jobno { get; set; }

    public int? LineFpaId { get; set; }

    public bool? IsDelete { get; set; }

    public string? Dimentionby { get; set; }
}
