using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class UserWiseShoulderImplantHistory
{
    public int Id { get; set; }

    public int Mid { get; set; }

    public int Pid { get; set; }

    public int UserId { get; set; }

    public string ImplantId { get; set; } = null!;

    public string? ImplantName { get; set; }

    public string? Manufacturer { get; set; }

    public string? ImplantImg { get; set; }
}
