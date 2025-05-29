using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class FamilyDetail
{
    public int FamilyId { get; set; }

    public int Id { get; set; }

    public string Relation { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Presentoccupation { get; set; } = null!;

    public string Nameoforganization { get; set; } = null!;
}
