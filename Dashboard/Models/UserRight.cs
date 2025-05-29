using System;
using System.Collections.Generic;

namespace Dashboard.Models;

public partial class UserRight
{
    public int TenentId { get; set; }

    public int RightsId { get; set; }

    public int LocationId { get; set; }

    public int? UserId { get; set; }

    public int? PrivilegeId { get; set; }

    public bool AddFlag { get; set; }

    public bool ModifyFlag { get; set; }

    public bool DeleteFlag { get; set; }

    public bool ViewFlag { get; set; }

    public bool AllFlag { get; set; }

    public long? CrupId { get; set; }

    public bool? IsLabelUpdate { get; set; }

    public bool? Sp1 { get; set; }

    public bool? Sp2 { get; set; }

    public bool? Sp3 { get; set; }

    public bool? Sp4 { get; set; }

    public bool? Sp5 { get; set; }

    public string? Sp1name { get; set; }

    public string? Sp2name { get; set; }

    public string? Sp3name { get; set; }

    public string? Sp4name { get; set; }

    public string? Sp5name { get; set; }

    public string? Status { get; set; }
}
