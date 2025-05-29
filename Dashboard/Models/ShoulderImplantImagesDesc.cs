using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class ShoulderImplantImagesDesc
{
    public int Id { get; set; }

    public int Pid { get; set; }

    public int Mid { get; set; }

    public string? ImplantId { get; set; }

    public string? ImplantName { get; set; }

    public string? ImplantImage { get; set; }
}
