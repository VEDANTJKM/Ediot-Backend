using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngineeringProcessMafiaDatum
{
    public int Id { get; set; }

    public string? Partnum { get; set; }

    public string? Rev { get; set; }

    public DateTime? MafiaStamp { get; set; }

    public bool? MafiaCreated { get; set; }

    public bool? MafiaVerified { get; set; }

    public bool? MafiaReleased { get; set; }
}
