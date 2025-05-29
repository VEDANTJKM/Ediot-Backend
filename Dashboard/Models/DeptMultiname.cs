using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptMultiname
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public string? TaskId { get; set; }

    public string? FormName { get; set; }

    public int? PersonId { get; set; }

    public string? PersonName { get; set; }

    public string? Type { get; set; }
}
