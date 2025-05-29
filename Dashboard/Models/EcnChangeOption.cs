using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EcnChangeOption
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Ecnid { get; set; }

    public int Pid { get; set; }

    public string? EcnName { get; set; }
}
