using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class TblFile
{
    public int Id { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }
}
