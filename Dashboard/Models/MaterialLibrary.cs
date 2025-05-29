using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class MaterialLibrary
{
    public int Id { get; set; }

    public int RefId { get; set; }

    public int Mid { get; set; }

    public string? Refname { get; set; }

    public string? SubRefName { get; set; }

    public string? Refname1 { get; set; }
}
