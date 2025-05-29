using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class Version
{
    public int Tid { get; set; }

    public int Id { get; set; }

    public string? Versionno { get; set; }

    public string? VersionUpdate { get; set; }
}
