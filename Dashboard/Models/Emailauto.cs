using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Emailauto
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public string? Email { get; set; }

    public string? Type { get; set; }

    public string? App { get; set; }

    public bool? Active { get; set; }
}
