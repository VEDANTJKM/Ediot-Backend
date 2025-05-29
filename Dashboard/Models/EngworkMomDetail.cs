using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class EngworkMomDetail
{
    public int Id { get; set; }

    public int Rid { get; set; }

    public int Mid { get; set; }

    public string OprationNum { get; set; } = null!;

    public string ProcessName { get; set; } = null!;
}
