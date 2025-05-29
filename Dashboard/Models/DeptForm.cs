using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class DeptForm
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string? FormName { get; set; }

    public bool? Active { get; set; }
}
