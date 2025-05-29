using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class NewFpaGdntSymbol
{
    public int Id { get; set; }

    public string? GdnySymbol { get; set; }

    public string? GdntSymbolName { get; set; }

    public string? GdntSymbolAndName { get; set; }
}
