using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EpoRefTable
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public int RefId { get; set; }

    public string? RefType { get; set; }

    public string? RefSubType { get; set; }

    public string? Refname { get; set; }
}
